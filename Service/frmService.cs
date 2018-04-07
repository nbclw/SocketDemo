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
        //与某个客户端通信套接字
        Socket _sokMsg = null;
        //通信线程
        Thread _thrMsg = null;
        #endregion


        private void btnStart_Click(object sender, EventArgs e)
        {
            Socket socketWatch  = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch.Bind(new IPEndPoint(IPAddress.Any, 2112));
            socketWatch.Listen(10);

            _thrMsg = new Thread(Listen);
            _thrMsg.IsBackground = false;
            _thrMsg.Start(socketWatch);
        }

        private void Listen(object obj)
        {
            Socket socketWatch = obj as Socket;
            while (true)
            {
                _sokMsg = socketWatch.Accept();
                Stream netStream = new NetworkStream(_sokMsg);
                StreamReader reader = new StreamReader(netStream);
                string result = reader.ReadToEnd();

                Thread.Sleep(1000);
            }
        }

        private void UpdateContent(string result)
        {
            rtxListen.AppendText("\n");
            rtxListen.AppendText(result);
        }
    }
}
