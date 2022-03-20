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
namespace Word_Book_UI
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
        WordListViewItem _CheckedItem;
        /// <summary>
        /// 被选中的Item
        /// </summary>
        public WordListViewItem CheckedItem {
            set {
                if (_CheckedItem!=value) {
                    _CheckedItem = value;
                    if (_CheckedItem != null) {
                        Item_Change();
                    }
                }
            }
            get { return _CheckedItem; }
        }
        /// <summary>
        /// Item改变的委托事件
        /// </summary>
        public delegate void ItemChange();
        /// <summary>
        /// 暴露Item改变的事件
        /// </summary>
        public event ItemChange Item_Change = ()=>{};
        /// <summary>
        /// 记录每个Item
        /// </summary>
        public List<WordListViewItem> Items = new List<WordListViewItem>();
        public int Row = 1;
        /// <summary>
        /// 添加项
        /// </summary>
        /// <param name="word">word</param>
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
        /// <summary>
        /// 清除全部项
        /// </summary>
        public void CleanAll() {
            Row = 0;
            Items = new List<WordListViewItem>();
            ListPanel.Controls.Clear();
             CheckedItem = null;
        }
        /// <summary>
        /// 清除选中项
        /// </summary>
        public void RemoveChecked() {
            ListPanel.Controls.Remove(CheckedItem);
        }
    }
}
