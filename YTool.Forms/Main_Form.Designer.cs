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
            this.txt_Main = new System.Windows.Forms.TextBox();
            this.btn_Deduplication = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Main;
        private System.Windows.Forms.Button btn_Deduplication;
        private System.Windows.Forms.Button btn_Sum;
    }
}

