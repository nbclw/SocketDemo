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
            this.pnlArcgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(210, 25);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(39, 15);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(270, 22);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 25);
            this.txtPort.TabIndex = 7;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(66, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 25);
            this.txtIP.TabIndex = 6;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(27, 25);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(23, 15);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP";
            // 
            // pnlArcgs
            // 
            this.pnlArcgs.Controls.Add(this.lblPort);
            this.pnlArcgs.Controls.Add(this.txtIP);
            this.pnlArcgs.Controls.Add(this.txtPort);
            this.pnlArcgs.Controls.Add(this.lblIP);
            this.pnlArcgs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArcgs.Location = new System.Drawing.Point(0, 0);
            this.pnlArcgs.Name = "pnlArcgs";
            this.pnlArcgs.Size = new System.Drawing.Size(800, 67);
            this.pnlArcgs.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(104, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(496, 249);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pnlArcgs);
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
    }
}

