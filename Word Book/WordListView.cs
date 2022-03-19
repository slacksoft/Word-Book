using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace EnglishPrison_UI
{
    /// <summary>
    /// 自绘List控件
    /// </summary>
    public partial class WordListView : UserControl
    {
        public WordListView()
        {
            InitializeComponent();
        }
        private void WordListView_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 被选中的Item
        /// </summary>
        public WordListViewItem CheckedItem ;
        /// <summary>
        /// 记录每个Item
        /// </summary>
        public List<WordListViewItem> Items = new List<WordListViewItem>();
        public int Row = 1;
        public void Add(TheWord word)
        {
            ListPanel.RowStyles.Add(new RowStyle());
            WordListViewItem wordListViewItem = new WordListViewItem(this,word);
            //wordListViewItem.Location=new Point(0, LocationY);
            wordListViewItem.Anchor = AnchorStyles.Left|AnchorStyles.Right| AnchorStyles.Top|AnchorStyles.Bottom;
            ListPanel.Controls.Add(wordListViewItem,0, Row);
            Items.Add(wordListViewItem);
            Row++;
        }
        public void Clean() {
            Row = 0;
            Items = new List<WordListViewItem>();
            ListPanel.Controls.Clear();
             CheckedItem = null;
        }
        public void RemoveChecked() {
            ListPanel.Controls.Remove(CheckedItem);
        }
    }
}
