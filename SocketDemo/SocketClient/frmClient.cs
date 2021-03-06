﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }


        #region 公共变量
        Socket _socketClient = null;
        byte[] _receiveBuffer = new byte[1024];
        byte[] _sendBuffer = new byte[1024];
        #endregion

        #region Method
        /// <summary>
        /// 初始化网络节点
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private bool InitPoint(out IPEndPoint point)
        {
            string ipStr = txtIP.Text;
            IPAddress ip;
            if (string.IsNullOrWhiteSpace(ipStr) || !IPAddress.TryParse(ipStr, out ip))
            {
                MessageBox.Show("IP ERROR!");
                point = null;
                return false;
            }

            string portStr = txtPort.Text;
            int portInt;
            if (string.IsNullOrWhiteSpace(portStr) || !int.TryParse(portStr, out portInt))
            {
                MessageBox.Show("Port ERROR!");
                point = null;
                return false;
            }
            point = new IPEndPoint(ip, portInt);

            return true;
        }

        /// <summary>
        /// 发送信息后的回掉
        /// </summary>
        /// <param name="ar"></param>
        private void ReceiveCallBack(IAsyncResult ar)
        {
            int REnd = _socketClient.EndReceive(ar);
            string strReceiveData = Encoding.Unicode.GetString(_receiveBuffer, 0, REnd);

            AppendMessageToBox(strReceiveData);
        }

        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="message"></param>
        private void SendMessage()
        {
            string strSendData = rtxMessage.Text;
            AppendMessageToBox(txtName.Text + "    " + DateTime.Now.ToString() + "：" + strSendData);
            SendMessage(strSendData);
        }
        private void SendMessage(string message)
        {
            _sendBuffer = Encoding.Unicode.GetBytes(message);
            if (_socketClient != null)
            {
                _socketClient.Send(_sendBuffer);
                rtxMessage.Clear();
            }
        }

        private void AppendMessageToBox(string message)
        {
            rtxContent.AppendText("-------------------");
            rtxContent.AppendText("\n");
            foreach (var str in message.Split('：'))
            {
                rtxContent.AppendText(str);
                rtxContent.AppendText("\n");
            }
            rtxContent.ScrollToCaret();

            ListenServer();
        }

        private void ListenServer()
        {
            _socketClient.BeginReceive(_receiveBuffer, 0, _receiveBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), null);
        }

        private void ControlEnable(bool enable)
        {
            txtIP.Enabled = enable;
            txtPort.Enabled = enable;
            btnOnline.Enabled = enable;
            rtxMessage.Enabled = !enable;
            btnSend.Enabled = !enable;
        }
        #endregion

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void rtxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.Handled = true;
            }
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            if (_socketClient == null)
                _socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint point;
            if (InitPoint(out point))
            {
                try
                {
                    _socketClient.Connect(point);
                    if (_socketClient.Connected)
                    {
                        SendMessage(txtName.Text);
                        ListenServer();
                        ControlEnable(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连入ERROR:" + ex.Message);
                    _socketClient.Dispose();
                    _socketClient = null;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
    }
}
