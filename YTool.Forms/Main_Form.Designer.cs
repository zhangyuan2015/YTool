namespace YTool.Forms
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.btn_Deduplication = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.nfi_MinWindow = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_nfi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Deduplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_json_format = new System.Windows.Forms.Button();
            this.btn_json_compression = new System.Windows.Forms.Button();
            this.btnImg2Base64 = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnDY = new System.Windows.Forms.Button();
            this.btnSY = new System.Windows.Forms.Button();
            this.btnDH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxFX = new System.Windows.Forms.CheckBox();
            this.btnBF = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGroupCount = new System.Windows.Forms.TextBox();
            this.btnGroup = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_Main = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnQC = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.cms_nfi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Deduplication
            // 
            this.btn_Deduplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deduplication.Location = new System.Drawing.Point(3, 3);
            this.btn_Deduplication.Name = "btn_Deduplication";
            this.btn_Deduplication.Size = new System.Drawing.Size(75, 23);
            this.btn_Deduplication.TabIndex = 1;
            this.btn_Deduplication.Text = "去重";
            this.btn_Deduplication.UseVisualStyleBackColor = true;
            this.btn_Deduplication.Click += new System.EventHandler(this.btn_Deduplication_Click);
            // 
            // btn_Sum
            // 
            this.btn_Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sum.Location = new System.Drawing.Point(84, 3);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(75, 23);
            this.btn_Sum.TabIndex = 2;
            this.btn_Sum.Text = "求和";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // nfi_MinWindow
            // 
            this.nfi_MinWindow.BalloonTipText = "YTool";
            this.nfi_MinWindow.ContextMenuStrip = this.cms_nfi;
            this.nfi_MinWindow.Icon = ((System.Drawing.Icon)(resources.GetObject("nfi_MinWindow.Icon")));
            this.nfi_MinWindow.Text = "Min Window";
            this.nfi_MinWindow.Visible = true;
            this.nfi_MinWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nfi_MinWindow_MouseClick);
            // 
            // cms_nfi
            // 
            this.cms_nfi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Deduplication,
            this.toolStripSeparator1,
            this.tsm_Close});
            this.cms_nfi.Name = "cms_nfi";
            this.cms_nfi.Size = new System.Drawing.Size(101, 54);
            // 
            // tsm_Deduplication
            // 
            this.tsm_Deduplication.Name = "tsm_Deduplication";
            this.tsm_Deduplication.Size = new System.Drawing.Size(100, 22);
            this.tsm_Deduplication.Text = "去重";
            this.tsm_Deduplication.Click += new System.EventHandler(this.tsm_Deduplication_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // tsm_Close
            // 
            this.tsm_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsm_Close.Name = "tsm_Close";
            this.tsm_Close.Size = new System.Drawing.Size(100, 22);
            this.tsm_Close.Text = "关闭";
            this.tsm_Close.Click += new System.EventHandler(this.tsm_Close_Click);
            // 
            // btn_json_format
            // 
            this.btn_json_format.Location = new System.Drawing.Point(165, 3);
            this.btn_json_format.Name = "btn_json_format";
            this.btn_json_format.Size = new System.Drawing.Size(79, 23);
            this.btn_json_format.TabIndex = 3;
            this.btn_json_format.Text = "Json 格式化";
            this.btn_json_format.UseVisualStyleBackColor = true;
            this.btn_json_format.Click += new System.EventHandler(this.btn_json_format_Click);
            // 
            // btn_json_compression
            // 
            this.btn_json_compression.Location = new System.Drawing.Point(84, 3);
            this.btn_json_compression.Name = "btn_json_compression";
            this.btn_json_compression.Size = new System.Drawing.Size(75, 23);
            this.btn_json_compression.TabIndex = 4;
            this.btn_json_compression.Text = "Json 压缩";
            this.btn_json_compression.UseVisualStyleBackColor = true;
            this.btn_json_compression.Click += new System.EventHandler(this.btn_json_compression_Click);
            // 
            // btnImg2Base64
            // 
            this.btnImg2Base64.Location = new System.Drawing.Point(84, 32);
            this.btnImg2Base64.Name = "btnImg2Base64";
            this.btnImg2Base64.Size = new System.Drawing.Size(91, 23);
            this.btnImg2Base64.TabIndex = 5;
            this.btnImg2Base64.Text = "图片 2 Base64";
            this.btnImg2Base64.UseVisualStyleBackColor = true;
            this.btnImg2Base64.Click += new System.EventHandler(this.btnImg2Base64_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(412, 3);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(75, 23);
            this.btnToUpper.TabIndex = 6;
            this.btnToUpper.Text = "转大写";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(165, 3);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(75, 23);
            this.btnToLower.TabIndex = 7;
            this.btnToLower.Text = "转小写";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // btnDY
            // 
            this.btnDY.Location = new System.Drawing.Point(2, -1);
            this.btnDY.Name = "btnDY";
            this.btnDY.Size = new System.Drawing.Size(26, 23);
            this.btnDY.TabIndex = 8;
            this.btnDY.Text = "\'\'";
            this.btnDY.UseVisualStyleBackColor = true;
            this.btnDY.Click += new System.EventHandler(this.btnDY_Click);
            // 
            // btnSY
            // 
            this.btnSY.Location = new System.Drawing.Point(32, -1);
            this.btnSY.Name = "btnSY";
            this.btnSY.Size = new System.Drawing.Size(26, 23);
            this.btnSY.TabIndex = 9;
            this.btnSY.Text = "\"\"";
            this.btnSY.UseVisualStyleBackColor = true;
            this.btnSY.Click += new System.EventHandler(this.btnSY_Click);
            // 
            // btnDH
            // 
            this.btnDH.Location = new System.Drawing.Point(64, -1);
            this.btnDH.Name = "btnDH";
            this.btnDH.Size = new System.Drawing.Size(26, 23);
            this.btnDH.TabIndex = 10;
            this.btnDH.Text = ",";
            this.btnDH.UseVisualStyleBackColor = true;
            this.btnDH.Click += new System.EventHandler(this.btnDH_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxFX);
            this.panel1.Controls.Add(this.btnDY);
            this.panel1.Controls.Add(this.btnDH);
            this.panel1.Controls.Add(this.btnSY);
            this.panel1.Location = new System.Drawing.Point(493, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 23);
            this.panel1.TabIndex = 11;
            // 
            // cbxFX
            // 
            this.cbxFX.AutoSize = true;
            this.cbxFX.Location = new System.Drawing.Point(96, 3);
            this.cbxFX.Name = "cbxFX";
            this.cbxFX.Size = new System.Drawing.Size(48, 16);
            this.cbxFX.TabIndex = 12;
            this.cbxFX.Text = "清除";
            this.cbxFX.UseVisualStyleBackColor = true;
            // 
            // btnBF
            // 
            this.btnBF.Location = new System.Drawing.Point(3, 32);
            this.btnBF.Name = "btnBF";
            this.btnBF.Size = new System.Drawing.Size(75, 23);
            this.btnBF.TabIndex = 12;
            this.btnBF.Text = "并发";
            this.btnBF.UseVisualStyleBackColor = true;
            this.btnBF.Click += new System.EventHandler(this.btnBF_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtGroupCount);
            this.panel2.Controls.Add(this.btnGroup);
            this.panel2.Location = new System.Drawing.Point(649, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 23);
            this.panel2.TabIndex = 13;
            // 
            // txtGroupCount
            // 
            this.txtGroupCount.Location = new System.Drawing.Point(3, 0);
            this.txtGroupCount.Name = "txtGroupCount";
            this.txtGroupCount.Size = new System.Drawing.Size(51, 21);
            this.txtGroupCount.TabIndex = 14;
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(59, -1);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(75, 23);
            this.btnGroup.TabIndex = 14;
            this.btnGroup.Text = "分组";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnToUpper);
            this.panel3.Controls.Add(this.btn_json_format);
            this.panel3.Controls.Add(this.btn_Sum);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnImg2Base64);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnBF);
            this.panel3.Location = new System.Drawing.Point(12, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 60);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Controls.Add(this.txtStatus);
            this.panel4.Controls.Add(this.txt_Main);
            this.panel4.Location = new System.Drawing.Point(12, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(796, 380);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(12, 522);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(796, 32);
            this.panel5.TabIndex = 16;
            // 
            // txt_Main
            // 
            this.txt_Main.Location = new System.Drawing.Point(0, 28);
            this.txt_Main.Multiline = true;
            this.txt_Main.Name = "txt_Main";
            this.txt_Main.Size = new System.Drawing.Size(796, 325);
            this.txt_Main.TabIndex = 16;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(0, 359);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(796, 21);
            this.txtStatus.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQC,
            this.toolStripSplitButton1,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnQC
            // 
            this.btnQC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQC.Image = ((System.Drawing.Image)(resources.GetObject("btnQC.Image")));
            this.btnQC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQC.Name = "btnQC";
            this.btnQC.Size = new System.Drawing.Size(36, 22);
            this.btnQC.Text = "去重";
            this.btnQC.ToolTipText = "toolStrip1Button1";
            this.btnQC.Click += new System.EventHandler(this.btnQC_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(144, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Deduplication);
            this.flowLayoutPanel1.Controls.Add(this.btn_json_compression);
            this.flowLayoutPanel1.Controls.Add(this.btnToLower);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(384, 136);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 100);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 559);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Main_Form";
            this.Text = "YTool";
            this.SizeChanged += new System.EventHandler(this.Main_Form_SizeChanged);
            this.cms_nfi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Deduplication;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.NotifyIcon nfi_MinWindow;
        private System.Windows.Forms.ContextMenuStrip cms_nfi;
        private System.Windows.Forms.ToolStripMenuItem tsm_Deduplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Close;
        private System.Windows.Forms.Button btn_json_format;
        private System.Windows.Forms.Button btn_json_compression;
        private System.Windows.Forms.Button btnImg2Base64;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnDY;
        private System.Windows.Forms.Button btnSY;
        private System.Windows.Forms.Button btnDH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxFX;
        private System.Windows.Forms.Button btnBF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.TextBox txtGroupCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_Main;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnQC;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

