namespace Service
{
    partial class frmService
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
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.pnlArcgs = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpListen = new System.Windows.Forms.GroupBox();
            this.rtxListen = new System.Windows.Forms.RichTextBox();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.rtxContent = new System.Windows.Forms.RichTextBox();
            this.pnlArcgs.SuspendLayout();
            this.grpListen.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(23, 18);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 12);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "连接数";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(73, 15);
            this.txtCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(76, 21);
            this.txtCount.TabIndex = 1;
            this.txtCount.Text = "10";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(212, 15);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "2112";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(166, 18);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // pnlArcgs
            // 
            this.pnlArcgs.Controls.Add(this.btnEnd);
            this.pnlArcgs.Controls.Add(this.btnStart);
            this.pnlArcgs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArcgs.Location = new System.Drawing.Point(0, 0);
            this.pnlArcgs.Margin = new System.Windows.Forms.Padding(2);
            this.pnlArcgs.Name = "pnlArcgs";
            this.pnlArcgs.Size = new System.Drawing.Size(600, 54);
            this.pnlArcgs.TabIndex = 4;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(402, 14);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(56, 23);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "结束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(316, 14);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpListen
            // 
            this.grpListen.Controls.Add(this.rtxListen);
            this.grpListen.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpListen.Location = new System.Drawing.Point(0, 54);
            this.grpListen.Margin = new System.Windows.Forms.Padding(2);
            this.grpListen.Name = "grpListen";
            this.grpListen.Padding = new System.Windows.Forms.Padding(2);
            this.grpListen.Size = new System.Drawing.Size(234, 306);
            this.grpListen.TabIndex = 5;
            this.grpListen.TabStop = false;
            this.grpListen.Text = "监听事件";
            // 
            // rtxListen
            // 
            this.rtxListen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxListen.Location = new System.Drawing.Point(2, 16);
            this.rtxListen.Margin = new System.Windows.Forms.Padding(2);
            this.rtxListen.Name = "rtxListen";
            this.rtxListen.Size = new System.Drawing.Size(230, 288);
            this.rtxListen.TabIndex = 0;
            this.rtxListen.Text = "";
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.rtxContent);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContent.Location = new System.Drawing.Point(234, 54);
            this.grpContent.Margin = new System.Windows.Forms.Padding(2);
            this.grpContent.Name = "grpContent";
            this.grpContent.Padding = new System.Windows.Forms.Padding(2);
            this.grpContent.Size = new System.Drawing.Size(366, 306);
            this.grpContent.TabIndex = 6;
            this.grpContent.TabStop = false;
            this.grpContent.Text = "内容";
            // 
            // rtxContent
            // 
            this.rtxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxContent.Location = new System.Drawing.Point(2, 16);
            this.rtxContent.Margin = new System.Windows.Forms.Padding(2);
            this.rtxContent.Name = "rtxContent";
            this.rtxContent.Size = new System.Drawing.Size(362, 288);
            this.rtxContent.TabIndex = 0;
            this.rtxContent.Text = "";
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.grpListen);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.pnlArcgs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmService";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmService_FormClosing);
            this.Load += new System.EventHandler(this.frmService_Load);
            this.pnlArcgs.ResumeLayout(false);
            this.grpListen.ResumeLayout(false);
            this.grpContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Panel pnlArcgs;
        private System.Windows.Forms.GroupBox grpListen;
        private System.Windows.Forms.RichTextBox rtxListen;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.RichTextBox rtxContent;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
    }
}

