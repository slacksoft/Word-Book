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
    public partial class WordListViewItem : UserControl
    {
        /// <summary>
        /// 父控件
        /// </summary>
        WordListView wordListView = new WordListView();
        /// <summary>
        /// 单词
        /// </summary>
        TheWord _word = new TheWord("Book","Lesson","Word","Translate");
        /// <summary>
        /// 被选中
        /// </summary>
        bool _isChecked = false;
        /// <summary>
        /// 单词成员变量
        /// </summary>
        public TheWord word
        {
            /*  将单词显示到界面  */
            set
            {
                _word = value;
                WordLabel.Text = value.word;
                TranslateLabel.Text = value.translate;
            }
            get
            {
                return _word;
            }
        }
        /// <summary>
        /// 被选中成员变量
        /// </summary>
        public bool isChecked
        {
            set
            {
                _isChecked = value;
                if (value)
                {
                    this.BackColor = Color.FromArgb(51, 51, 51);
                }
                else
                {
                    this.BackColor = Color.FromArgb(25, 25, 25);
                }
            }
            get { return _isChecked; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="wordListView">父控件</param>
        /// <param name="word">单词</param>
        public WordListViewItem(WordListView wordListView,TheWord word)
        {
            InitializeComponent();
            this.word = word;
            this.wordListView = wordListView;
        }
        /// <summary>
        /// 被点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Checked(object sender, EventArgs e) {
            isChecked=true;
            wordListView.CheckedItem = this;
            /*   循环所有Item不是自己本身设置为不被选中   */
            foreach (WordListViewItem item in wordListView.Items) {
                if (item != this) { 
                    item.isChecked = false;
                }
            }
        }
    }
}
