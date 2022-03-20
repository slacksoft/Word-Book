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
using DAL;
namespace Word_Book_UI
{
    public partial class WordListViewFull : UserControl
    {
        public WordListViewFull()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 列表里的所有单词缓冲区
        /// </summary>
        public List<TheWord> TheWordsBuff;
        /// <summary>
        /// 列表里的所有单词
        /// </summary>
        public List<TheWord> TheWords = new List<TheWord>();
        /// <summary>
        /// 切分列表用于分页显示
        /// </summary>
        public List<List<TheWord>> TheWordspage = new List<List<TheWord>>();
        /// <summary>
        /// 当前页面位置
        /// </summary>
        public int _position = 0;
        public int position
        {
            set
            {
                _position = value;
                if (_position < TheWordspage.Count)
                {
                    ShowList(_position);
                }
                Page.Text = (_position + 1).ToString() + " / " + TheWordspage.Count;
            }
            get { return _position; }
        }

        /// <summary>
        /// Item改变的委托事件
        /// </summary>
        public delegate void ItemChange();
        /// <summary>
        /// 暴露Item改变的事件
        /// </summary>
        public event ItemChange Item_Change = () => { };
        /// <summary>
        /// 手动继承Item改变事件 (雾)
        /// </summary>
        private void wordListView_ChangeNum()
        {
            Item_Change();
        }
        /// <summary>
        /// 手动继承Add (bushi)
        /// </summary>
        /// <param name="word">单词类</param>
        public void Add(TheWord word)
        {
            wordListView.Add(word);
        }
        /// <summary>
        /// 手动继承CleanAll (233)
        /// </summary>
        public void CleanAll()
        {
            wordListView.CleanAll();
        }
        /// <summary>
        /// 手动继承RemoveChecked (随便了，就算不算继承，说错了也没关系)
        /// </summary>
        public void RemoveChecked()
        {
            wordListView.RemoveChecked();
        }
        /// <summary>
        /// 主线程锁
        /// </summary>
        public static int MainTaskLock = 0;
        /// <summary>
        /// 显示线程锁
        /// </summary>
        public static object TaskLock = 0;
        /// <summary>
        /// 显示某一页
        /// </summary>
        /// <param name="position">位置</param>
        public void ShowList(int position)
        {
            wordListView.ListPanel.SuspendLayout();
            MainTaskLock = 1;
            wordListView.CleanAll();
            Task task = new Task(() =>
            {
                lock (wordListView)
                {
                    foreach (TheWord theWord in TheWordspage[position])
                    {
                       // Thread.Sleep(10);
                        this.Invoke(new Action(() =>
                        {
                            wordListView.Add(theWord);
                        }
                        ));
                    }
                    this.Invoke(new Action(() =>
                    {
                        MainTaskLock = 0;
                        wordListView.ListPanel.ResumeLayout();
                    }));
                }

            });
            task.Start();
        }

        /// <summary>
        /// 切分项
        /// </summary>
        public void CutWordList()
        {
            TheWordspage.Clear();
            int i = 0;
            int j = 0;
            TheWordspage.Add(new List<TheWord>());
            foreach (TheWord theWord in TheWords)
            {

                TheWordspage[i].Add(theWord);
                j++;
                //j是切分个数
                if (j > 50)
                {
                    TheWordspage.Add(new List<TheWord>());
                    j = 0;
                    i++;
                }
            }
        }
        /// <summary>
        /// 设置值（类似构造函数）
        /// </summary>
        /// <param name="TheWords"></param>
        public void SetValue(List<TheWord> TheWords)
        {
            this.TheWords = TheWords;
            if (TheWordsBuff == null) {
                TheWordsBuff = (from w in TheWords select w).ToList();
            }
            CutWordList();
            position = 0;
        }

        private void cut_btn_Click(object sender, EventArgs e)
        {
            if (_position > 0 && MainTaskLock == 0)
            {
                position--;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            if (_position < TheWordspage.Count - 1&& MainTaskLock == 0)
            {
                position++;
            }
        }

        private void wordListView_Item_Change()
        {
            Item_Change();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            Task task = new Task(() => {
                lock (wordListView)
                {
                    if (searchBox.Text != "")
                    {
                        TheWords = (from w in TheWordsBuff select w).ToList();
                        TheWordsBuff = (from w in TheWords select w).ToList();
                        TheWords = (from w in TheWords where w.word.Contains(searchBox.Text) select w).ToList();
                        this.Invoke(new Action(() =>
                        {
                            SetValue(TheWords);
                        }));
                    }
                    else
                    {
                        TheWords = (from w in TheWordsBuff select w).ToList();
                        this.Invoke(new Action(() =>
                        {
                            SetValue(TheWords);
                        }));
                    }
                }
            });
            task.Start();
        }
    }
}
