namespace SocketClient
{
    partial class frmClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.pnlArcgs = new System.Windows.Forms.Panel();
            this.btnOnline = new System.Windows.Forms.Button();
            this.rtxContent = new System.Windows.Forms.RichTextBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlArcgs.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(158, 20);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(202, 18);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 21);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "2112";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(50, 18);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(76, 21);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "127.0.0.1";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(20, 20);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 12);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP";
            // 
            // pnlArcgs
            // 
            this.pnlArcgs.Controls.Add(this.txtName);
            this.pnlArcgs.Controls.Add(this.btnOnline);
            this.pnlArcgs.Controls.Add(this.lblPort);
            this.pnlArcgs.Controls.Add(this.txtIP);
            this.pnlArcgs.Controls.Add(this.txtPort);
            this.pnlArcgs.Controls.Add(this.lblIP);
            this.pnlArcgs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArcgs.Location = new System.Drawing.Point(0, 0);
            this.pnlArcgs.Margin = new System.Windows.Forms.Padding(2);
            this.pnlArcgs.Name = "pnlArcgs";
            this.pnlArcgs.Size = new System.Drawing.Size(600, 54);
            this.pnlArcgs.TabIndex = 9;
            // 
            // btnOnline
            // 
            this.btnOnline.Location = new System.Drawing.Point(299, 16);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(75, 23);
            this.btnOnline.TabIndex = 9;
            this.btnOnline.Text = "链接";
            this.btnOnline.UseVisualStyleBackColor = true;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // rtxContent
            // 
            this.rtxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxContent.Location = new System.Drawing.Point(0, 54);
            this.rtxContent.Margin = new System.Windows.Forms.Padding(2);
            this.rtxContent.Name = "rtxContent";
            this.rtxContent.Size = new System.Drawing.Size(600, 236);
            this.rtxContent.TabIndex = 10;
            this.rtxContent.Text = "";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 54);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(600, 236);
            this.pnlContent.TabIndex = 11;
            // 
            // pnlMessage
            // 
            this.pnlMessage.Controls.Add(this.btnSend);
            this.pnlMessage.Controls.Add(this.rtxMessage);
            this.pnlMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMessage.Location = new System.Drawing.Point(0, 290);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(600, 70);
            this.pnlMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(499, 23);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtxMessage
            // 
            this.rtxMessage.Enabled = false;
            this.rtxMessage.Location = new System.Drawing.Point(4, 3);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(476, 64);
            this.rtxMessage.TabIndex = 0;
            this.rtxMessage.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(423, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "user1";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.rtxContent);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlArcgs);
            this.Controls.Add(this.pnlMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "聊天室";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.pnlArcgs.ResumeLayout(false);
            this.pnlArcgs.PerformLayout();
            this.pnlMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Panel pnlArcgs;
        private System.Windows.Forms.RichTextBox rtxContent;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.TextBox txtName;
    }
}

