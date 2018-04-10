using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
        }

        #region 公共变量
        Socket _sokWatch;
        Thread _thrMsg;

        //用于停止Socket
        bool _isSocketConn;
        Socket _socClosed;
        IPEndPoint _pointClosed;

        //存储客户端信息
        List<Client> _clients;
        #endregion

        #region Method
        /// <summary>
        /// 初始化监听端口
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        private bool InitPort(out int port)
        {
            string portStr = txtPort.Text;
            if (string.IsNullOrWhiteSpace(portStr))
            {
                MessageBox.Show("端口Port为空！");
                port = 0;
                return false;
            }

            return int.TryParse(portStr, out port);
        }

        /// <summary>
        /// 初始化Socket监视
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        private bool InitSocketWatch(int port)
        {
            bool b = true;
            if (_sokWatch == null)
                _sokWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            int listenCount;
            if (!int.TryParse(txtCount.Text, out listenCount))
                listenCount = 100;

            try
            {
                _sokWatch.Bind(new IPEndPoint(IPAddress.Any, port));
                _sokWatch.Listen(listenCount);
            }
            catch (Exception e)
            {
                _sokWatch.Dispose();
                _sokWatch = null;
                MessageBox.Show("初始化Socket监视ERROR:" + e.Message);
                b = false;
            }

            return b;
        }

        /// <summary>
        /// 初始化管理监听，自己调用自己一下
        /// </summary>
        /// <param name="port"></param>
        private void InitSocketClosed(int port)
        {
            if (_socClosed != null) return;
            _socClosed = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _pointClosed = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
        }

        /// <summary>
        /// 监听
        /// </summary>
        /// <param name="obj"></param>
        private void Listen()
        {
            Invoke(new Action<string>(UpdateListen), "开始监听...");

            Socket socketConn = null;
            while (_isSocketConn)
            {
                try
                {
                    socketConn = _sokWatch.Accept();
                    if (!_isSocketConn) break;

                    string remoteEndPoint = socketConn.RemoteEndPoint.ToString();
                    Invoke(new Action<string>(UpdateListen), remoteEndPoint.ToString() + "：成功连入");

                    ThreadPool.QueueUserWorkItem(new WaitCallback(ReceiveMessage), socketConn);
                }
                catch (Exception e)
                {
                    Invoke(new Action(delegate
                    {
                        UpdateListen("监听ERROR:" + e.Message);
                        ControlDisplay(true);
                    }));

                    socketConn.Close();
                    _sokWatch.Close();
                    _isSocketConn = false;
                    break;
                }
            }

            socketConn.Close();
            _sokWatch.Close();
            _sokWatch.Dispose();
            _sokWatch = null;
            Invoke(new Action(delegate
            {
                UpdateListen("监听结束");
                ControlDisplay(true);
            }));
        }

        /// <summary>
        /// 接收信息
        /// </summary>
        /// <param name="obj"></param>
        private void ReceiveMessage(object obj)
        {
            Socket socketService = obj as Socket;
            string point = socketService.RemoteEndPoint.ToString();
            bool isLoop = true;
            while (isLoop)
            {
                string strSendData = string.Empty;
                Client currClient = null;
                currClient = _clients.Where(c => c.SocketServer == socketService).FirstOrDefault();
                try
                {
                    byte[] receiveBuffer = new byte[1024];
                    socketService.Receive(receiveBuffer);
                    string strReceiveData = Encoding.Unicode.GetString(receiveBuffer).Trim('\0');
                    if (!string.IsNullOrWhiteSpace(strReceiveData))
                    {
                        if (currClient == null)
                        {
                            currClient = new Client();
                            currClient.Token = strReceiveData;
                            currClient.SocketServer = socketService;
                            _clients.Add(currClient);

                            strSendData = currClient.Token + "：进入聊天室";
                            Invoke(new Action<string>(UpdateListen), strSendData);
                            currClient = null;
                        }
                        else
                        {
                            Invoke(new Action<string>(UpdateContent), "-------------------");
                            Invoke(new Action<string>(UpdateContent), currClient.Token + "    " + DateTime.Now.ToString() + "：");
                            Invoke(new Action<string>(UpdateContent), strReceiveData);

                            strSendData = currClient.Token + "    " + DateTime.Now.ToString() + "：" + strReceiveData;
                        }

                        SendMessage(strSendData, socketService);
                    }
                }
                catch (Exception e)
                {
                    isLoop = false;
                    Invoke(new Action<string>(UpdateListen), point + "：断开连接");
                    Invoke(new Action<string>(UpdateListen), e.Message);
                    SendMessage(currClient.Token + "：退出聊天室", socketService);
                    _clients.Remove(currClient);
                    socketService = null;
                }

            }
        }

        private void SendMessage(string message, Socket currSocket)
        {
            int sendBufferSize = Encoding.Unicode.GetByteCount(message);
            byte[] sendBuffer = new byte[sendBufferSize];
            sendBuffer = Encoding.Unicode.GetBytes(message);

            foreach (var client in _clients)
            {
                if (client.SocketServer != currSocket)
                    client.SocketServer.Send(sendBuffer);
            }
        }

        /// <summary>
        /// 更新内容
        /// </summary>
        /// <param name="result"></param>
        private void UpdateListen(string result)
        {
            if (rtxListen.TextLength > 0)
                rtxListen.AppendText("\n");

            rtxListen.AppendText(result);
            rtxListen.ScrollToCaret();
        }
        private void UpdateContent(string result)
        {
            if (rtxListen.TextLength > 0)
                rtxContent.AppendText("\n");

            rtxContent.AppendText(result);
            rtxContent.ScrollToCaret();
        }

        /// <summary>
        /// 控件控制是否启用
        /// </summary>
        /// <param name="enable"></param>
        private void ControlDisplay(bool enable)
        {
            txtCount.Enabled = enable;
            txtPort.Enabled = enable;
            btnStart.Enabled = enable;
            btnEnd.Enabled = !enable;
        }

        #endregion

        private void frmService_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_isSocketConn = false;
            //if (_socClosed != null)
            //{
            //    _socClosed.Connect(_pointClosed);
            //    _socClosed.Close();
            //}
            if (_isSocketConn)
            {
                MessageBox.Show("Socket正在运行，请先停止！");
                e.Cancel = true;
            }
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            _clients = new List<Client>();
            ControlDisplay(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int port;
            if (InitPort(out port))
            {
                if (InitSocketWatch(port))
                {
                    InitSocketClosed(port);
                    _isSocketConn = true;
                    _thrMsg = new Thread(Listen);
                    _thrMsg.IsBackground = false;
                    _thrMsg.Start();
                    ControlDisplay(false);
                }
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            _isSocketConn = false;
            if (_socClosed != null)
            {
                _socClosed.Connect(_pointClosed);
                _socClosed.Close();
                _socClosed.Dispose();
                _socClosed = null;
            }
        }
    }
}
