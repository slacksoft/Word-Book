namespace Word_Book_UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordListViewFull1 = new Word_Book_UI.WordListViewFull();
            this.SuspendLayout();
            // 
            // wordListViewFull1
            // 
            this.wordListViewFull1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.wordListViewFull1.ForeColor = System.Drawing.Color.White;
            this.wordListViewFull1.Location = new System.Drawing.Point(12, 12);
            this.wordListViewFull1.Name = "wordListViewFull1";
            this.wordListViewFull1.position = 0;
            this.wordListViewFull1.Size = new System.Drawing.Size(342, 601);
            this.wordListViewFull1.TabIndex = 0;
            this.wordListViewFull1.Item_Change += new Word_Book_UI.WordListViewFull.ItemChange(this.wordListViewFull1_Item_Change);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(962, 625);
            this.Controls.Add(this.wordListViewFull1);
            this.Name = "MainForm";
            this.Text = "Word Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Word_Book_UI.WordListViewFull wordListViewFull1;
    }
}