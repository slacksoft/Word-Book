namespace Word_Book_UI
{
    partial class WordListViewItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.WordLabel = new System.Windows.Forms.Label();
            this.TranslateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WordLabel.ForeColor = System.Drawing.Color.White;
            this.WordLabel.Location = new System.Drawing.Point(24, 12);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(63, 25);
            this.WordLabel.TabIndex = 0;
            this.WordLabel.Text = "Word";
            this.WordLabel.Click += new System.EventHandler(this.Checked);
            // 
            // TranslateLabel
            // 
            this.TranslateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TranslateLabel.AutoSize = true;
            this.TranslateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranslateLabel.ForeColor = System.Drawing.Color.White;
            this.TranslateLabel.Location = new System.Drawing.Point(24, 41);
            this.TranslateLabel.Name = "TranslateLabel";
            this.TranslateLabel.Size = new System.Drawing.Size(75, 20);
            this.TranslateLabel.TabIndex = 1;
            this.TranslateLabel.Text = "Translate";
            this.TranslateLabel.Click += new System.EventHandler(this.Checked);
            // 
            // WordListViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TranslateLabel);
            this.Controls.Add(this.WordLabel);
            this.Name = "WordListViewItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(513, 75);
            this.Click += new System.EventHandler(this.Checked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WordLabel;
        private Label TranslateLabel;
    }
}
