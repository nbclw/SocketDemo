namespace Service
{
    partial class s
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
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.pnlArcgs = new System.Windows.Forms.Panel();
            this.grpListen = new System.Windows.Forms.GroupBox();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.rtxListen = new System.Windows.Forms.RichTextBox();
            this.rtxContent = new System.Windows.Forms.RichTextBox();
            this.grpListen.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(39, 22);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(23, 15);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(78, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 25);
            this.txtIP.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(282, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 25);
            this.txtPort.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(222, 22);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(39, 15);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // pnlArcgs
            // 
            this.pnlArcgs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArcgs.Location = new System.Drawing.Point(0, 0);
            this.pnlArcgs.Name = "pnlArcgs";
            this.pnlArcgs.Size = new System.Drawing.Size(800, 67);
            this.pnlArcgs.TabIndex = 4;
            // 
            // grpListen
            // 
            this.grpListen.Controls.Add(this.rtxListen);
            this.grpListen.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpListen.Location = new System.Drawing.Point(0, 67);
            this.grpListen.Name = "grpListen";
            this.grpListen.Size = new System.Drawing.Size(312, 383);
            this.grpListen.TabIndex = 5;
            this.grpListen.TabStop = false;
            this.grpListen.Text = "监听事件";
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.rtxContent);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContent.Location = new System.Drawing.Point(312, 67);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(488, 383);
            this.grpContent.TabIndex = 6;
            this.grpContent.TabStop = false;
            this.grpContent.Text = "内容";
            // 
            // rtxListen
            // 
            this.rtxListen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxListen.Location = new System.Drawing.Point(3, 21);
            this.rtxListen.Name = "rtxListen";
            this.rtxListen.Size = new System.Drawing.Size(306, 359);
            this.rtxListen.TabIndex = 0;
            this.rtxListen.Text = "";
            // 
            // rtxContent
            // 
            this.rtxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxContent.Location = new System.Drawing.Point(3, 21);
            this.rtxContent.Name = "rtxContent";
            this.rtxContent.Size = new System.Drawing.Size(482, 359);
            this.rtxContent.TabIndex = 0;
            this.rtxContent.Text = "";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.grpListen);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.pnlArcgs);
            this.Name = "s";
            this.Text = "Form1";
            this.grpListen.ResumeLayout(false);
            this.grpContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Panel pnlArcgs;
        private System.Windows.Forms.GroupBox grpListen;
        private System.Windows.Forms.RichTextBox rtxListen;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.RichTextBox rtxContent;
    }
}

