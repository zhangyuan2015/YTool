﻿namespace YTool.Forms
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
            this.txt_Main = new System.Windows.Forms.TextBox();
            this.btn_Deduplication = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.nfi_MinWindow = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_nfi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Deduplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_nfi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Main
            // 
            this.txt_Main.Location = new System.Drawing.Point(12, 46);
            this.txt_Main.Multiline = true;
            this.txt_Main.Name = "txt_Main";
            this.txt_Main.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Main.Size = new System.Drawing.Size(776, 345);
            this.txt_Main.TabIndex = 0;
            this.txt_Main.WordWrap = false;
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
            this.cms_nfi.Size = new System.Drawing.Size(181, 76);
            // 
            // tsm_Deduplication
            // 
            this.tsm_Deduplication.Name = "tsm_Deduplication";
            this.tsm_Deduplication.Size = new System.Drawing.Size(180, 22);
            this.tsm_Deduplication.Text = "去重";
            this.tsm_Deduplication.Click += new System.EventHandler(this.tsm_Deduplication_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsm_Close
            // 
            this.tsm_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsm_Close.Name = "tsm_Close";
            this.tsm_Close.Size = new System.Drawing.Size(180, 22);
            this.tsm_Close.Text = "关闭";
            this.tsm_Close.Click += new System.EventHandler(this.tsm_Close_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 411);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.btn_Deduplication);
            this.Controls.Add(this.txt_Main);
            this.Name = "Main_Form";
            this.Text = "YTool";
            this.SizeChanged += new System.EventHandler(this.Main_Form_SizeChanged);
            this.cms_nfi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Main;
        private System.Windows.Forms.Button btn_Deduplication;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.NotifyIcon nfi_MinWindow;
        private System.Windows.Forms.ContextMenuStrip cms_nfi;
        private System.Windows.Forms.ToolStripMenuItem tsm_Deduplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Close;
    }
}

