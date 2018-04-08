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
        Socket _sokConn = null;
        Thread _thrMsg = null;
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
        /// <param name="listenCount"></param>
        /// <returns></returns>
        private Socket InitSocketWatch(int port, int listenCount)
        {
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socketWatch.Bind(new IPEndPoint(IPAddress.Any, port));
                socketWatch.Listen(listenCount);
            }
            catch (Exception e)
            {
                socketWatch.Dispose();
                socketWatch = null;
                MessageBox.Show("初始化Socket监视ERROR:" + e.Message);
            }

            return socketWatch;
        }

        /// <summary>
        /// 监听
        /// </summary>
        /// <param name="obj"></param>
        private void Listen(object obj)
        {
            Socket socketWatch = obj as Socket;
            while (true)
            {
                try
                {
                    Invoke(new Action(delegate
                    {
                        rtxListen.AppendText("开始监听... \n");
                        rtxListen.ScrollToCaret();
                    }));

                    _sokConn = socketWatch.Accept();


                    IPAddress clientIP = (_sokConn.RemoteEndPoint as IPEndPoint).Address;
                    int clientPort = (_sokConn.RemoteEndPoint as IPEndPoint).Port;
                    string remoteEndPoint = _sokConn.RemoteEndPoint.ToString();
                    Invoke(new Action(delegate
                    {
                        rtxContent.AppendText(clientIP.ToString());
                        rtxContent.AppendText(clientPort.ToString());
                        rtxContent.AppendText(remoteEndPoint.ToString());
                        rtxContent.ScrollToCaret();
                    }));


                    _sokConn.Close();

                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    MessageBox.Show("监听ERROR:" + e.Message);
                    socketWatch.Dispose();
                    _sokConn.Dispose();
                    break;
                }
            }

            socketWatch.Dispose();
            _sokConn.Dispose();

            Invoke(new Action(delegate
            {
                rtxListen.AppendText("监听结束 \n");
                rtxListen.ScrollToCaret();
                ControlDisplay(true);
            }));
        }

        /// <summary>
        /// 更新内容
        /// </summary>
        /// <param name="result"></param>
        private void UpdateContent(string result)
        {
            rtxListen.AppendText("\n");
            rtxListen.AppendText(result);
        }

        /// <summary>
        /// 控件控制是否启用
        /// </summary>
        /// <param name="enable"></param>
        private void ControlDisplay(bool enable)
        {
            txtIP.Enabled = enable;
            txtPort.Enabled = enable;
            btnStart.Enabled = enable;
            btnEnd.Enabled = !enable;
        }
        #endregion

        private void frmService_Load(object sender, EventArgs e)
        {
            ControlDisplay(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int port;
            if (InitPort(out port))
            {
                Socket socketWatch = InitSocketWatch(port, 10);
                if (socketWatch != null)
                {
                    _thrMsg = new Thread(Listen);
                    _thrMsg.IsBackground = false;
                    _thrMsg.Start(socketWatch);
                    ControlDisplay(false);
                }
            }
        }
    }
}
