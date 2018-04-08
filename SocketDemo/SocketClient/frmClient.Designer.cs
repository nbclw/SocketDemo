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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOnline = new System.Windows.Forms.Button();
            this.pnlArcgs.SuspendLayout();
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
            this.txtPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 21);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "2112";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(50, 18);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pnlArcgs.Controls.Add(this.btnOnline);
            this.pnlArcgs.Controls.Add(this.lblPort);
            this.pnlArcgs.Controls.Add(this.txtIP);
            this.pnlArcgs.Controls.Add(this.txtPort);
            this.pnlArcgs.Controls.Add(this.lblIP);
            this.pnlArcgs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArcgs.Location = new System.Drawing.Point(0, 0);
            this.pnlArcgs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlArcgs.Name = "pnlArcgs";
            this.pnlArcgs.Size = new System.Drawing.Size(600, 54);
            this.pnlArcgs.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(78, 104);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(373, 200);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
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
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pnlArcgs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmClient";
            this.ShowIcon = false;
            this.Text = "聊天室";
            this.pnlArcgs.ResumeLayout(false);
            this.pnlArcgs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Panel pnlArcgs;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnOnline;
    }
}

