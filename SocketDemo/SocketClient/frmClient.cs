using System;
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
        Socket socketclient = null;
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
        #endregion

        private void btnOnline_Click(object sender, EventArgs e)
        {
            btnOnline.Enabled = false;
            socketclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint point;
            if (InitPoint(out point))
            {
                socketclient.Connect(point);
            }
        }
    }
}
