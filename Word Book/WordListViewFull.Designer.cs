namespace Word_Book_UI
{
    partial class WordListViewFull
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.wordListView = new Word_Book_UI.WordListView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Page = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Label();
            this.cut_btn = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.wordListView, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.searchBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(319, 522);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // wordListView
            // 
            this.wordListView.AutoScroll = true;
            this.wordListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.wordListView.CheckedItem = null;
            this.wordListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordListView.Location = new System.Drawing.Point(2, 32);
            this.wordListView.Margin = new System.Windows.Forms.Padding(1);
            this.wordListView.Name = "wordListView";
            this.wordListView.Size = new System.Drawing.Size(315, 438);
            this.wordListView.TabIndex = 0;
            this.wordListView.Item_Change += new Word_Book_UI.WordListView.ItemChange(this.wordListView_Item_Change);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(3, 9);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(313, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.Page);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.cut_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 472);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 48);
            this.panel1.TabIndex = 2;
            // 
            // Page
            // 
            this.Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Page.Location = new System.Drawing.Point(47, 0);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(221, 48);
            this.Page.TabIndex = 2;
            this.Page.Text = "0 / 0";
            this.Page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_btn
            // 
            this.add_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.add_btn.Location = new System.Drawing.Point(268, 0);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(47, 48);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "▶";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cut_btn
            // 
            this.cut_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cut_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cut_btn.Location = new System.Drawing.Point(0, 0);
            this.cut_btn.Margin = new System.Windows.Forms.Padding(3);
            this.cut_btn.Name = "cut_btn";
            this.cut_btn.Size = new System.Drawing.Size(47, 48);
            this.cut_btn.TabIndex = 0;
            this.cut_btn.Text = "◀️";
            this.cut_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cut_btn.Click += new System.EventHandler(this.cut_btn_Click);
            // 
            // WordListViewFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.tableLayoutPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "WordListViewFull";
            this.Size = new System.Drawing.Size(319, 522);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        public  WordListView wordListView;
        private TextBox searchBox;
        private Panel panel1;
        private Label cut_btn;
        private Label add_btn;
        private Label Page;
    }
}
