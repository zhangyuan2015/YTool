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
            this.btnGroup = new System.Windows.Forms.Button();
            this.txtGroupCount = new System.Windows.Forms.TextBox();
            this.txt_Main = new System.Windows.Forms.RichTextBox();
            this.cms_nfi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Deduplication
            // 
            this.btn_Deduplication.Location = new System.Drawing.Point(12, 12);
            this.btn_Deduplication.Name = "btn_Deduplication";
            this.btn_Deduplication.Size = new System.Drawing.Size(75, 23);
            this.btn_Deduplication.TabIndex = 1;
            this.btn_Deduplication.Text = "去重";
            this.btn_Deduplication.UseVisualStyleBackColor = true;
            this.btn_Deduplication.Click += new System.EventHandler(this.btn_Deduplication_Click);
            // 
            // btn_Sum
            // 
            this.btn_Sum.Location = new System.Drawing.Point(93, 12);
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
            this.btn_json_format.Location = new System.Drawing.Point(174, 12);
            this.btn_json_format.Name = "btn_json_format";
            this.btn_json_format.Size = new System.Drawing.Size(79, 23);
            this.btn_json_format.TabIndex = 3;
            this.btn_json_format.Text = "Json 格式化";
            this.btn_json_format.UseVisualStyleBackColor = true;
            this.btn_json_format.Click += new System.EventHandler(this.btn_json_format_Click);
            // 
            // btn_json_compression
            // 
            this.btn_json_compression.Location = new System.Drawing.Point(259, 12);
            this.btn_json_compression.Name = "btn_json_compression";
            this.btn_json_compression.Size = new System.Drawing.Size(75, 23);
            this.btn_json_compression.TabIndex = 4;
            this.btn_json_compression.Text = "Json 压缩";
            this.btn_json_compression.UseVisualStyleBackColor = true;
            this.btn_json_compression.Click += new System.EventHandler(this.btn_json_compression_Click);
            // 
            // btnImg2Base64
            // 
            this.btnImg2Base64.Location = new System.Drawing.Point(340, 12);
            this.btnImg2Base64.Name = "btnImg2Base64";
            this.btnImg2Base64.Size = new System.Drawing.Size(86, 23);
            this.btnImg2Base64.TabIndex = 5;
            this.btnImg2Base64.Text = "图片2Base64";
            this.btnImg2Base64.UseVisualStyleBackColor = true;
            this.btnImg2Base64.Click += new System.EventHandler(this.btnImg2Base64_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(432, 12);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(75, 23);
            this.btnToUpper.TabIndex = 6;
            this.btnToUpper.Text = "转大写";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(513, 12);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(75, 23);
            this.btnToLower.TabIndex = 7;
            this.btnToLower.Text = "转小写";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // btnDY
            // 
            this.btnDY.Location = new System.Drawing.Point(0, 0);
            this.btnDY.Name = "btnDY";
            this.btnDY.Size = new System.Drawing.Size(26, 23);
            this.btnDY.TabIndex = 8;
            this.btnDY.Text = "\'\'";
            this.btnDY.UseVisualStyleBackColor = true;
            this.btnDY.Click += new System.EventHandler(this.btnDY_Click);
            // 
            // btnSY
            // 
            this.btnSY.Location = new System.Drawing.Point(32, 0);
            this.btnSY.Name = "btnSY";
            this.btnSY.Size = new System.Drawing.Size(26, 23);
            this.btnSY.TabIndex = 9;
            this.btnSY.Text = "\"\"";
            this.btnSY.UseVisualStyleBackColor = true;
            this.btnSY.Click += new System.EventHandler(this.btnSY_Click);
            // 
            // btnDH
            // 
            this.btnDH.Location = new System.Drawing.Point(64, 0);
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
            this.panel1.Location = new System.Drawing.Point(594, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 25);
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
            this.btnBF.Location = new System.Drawing.Point(12, 41);
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
            this.panel2.Location = new System.Drawing.Point(93, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 25);
            this.panel2.TabIndex = 13;
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(59, 0);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(75, 23);
            this.btnGroup.TabIndex = 14;
            this.btnGroup.Text = "分组";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // txtGroupCount
            // 
            this.txtGroupCount.Location = new System.Drawing.Point(3, 1);
            this.txtGroupCount.Name = "txtGroupCount";
            this.txtGroupCount.Size = new System.Drawing.Size(51, 21);
            this.txtGroupCount.TabIndex = 14;
            // 
            // txt_Main
            // 
            this.txt_Main.Location = new System.Drawing.Point(12, 70);
            this.txt_Main.Name = "txt_Main";
            this.txt_Main.Size = new System.Drawing.Size(780, 333);
            this.txt_Main.TabIndex = 14;
            this.txt_Main.Text = "";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 415);
            this.Controls.Add(this.txt_Main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.btnImg2Base64);
            this.Controls.Add(this.btn_json_compression);
            this.Controls.Add(this.btn_json_format);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.btn_Deduplication);
            this.Name = "Main_Form";
            this.Text = "YTool";
            this.SizeChanged += new System.EventHandler(this.Main_Form_SizeChanged);
            this.cms_nfi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.RichTextBox txt_Main;
    }
}

