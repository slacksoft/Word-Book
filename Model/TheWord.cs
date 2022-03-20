using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 单词类
    /// </summary>
    [Serializable]
    public class TheWord
    {
        /// <summary>
        /// 课本
        /// </summary>
        public string bookid = "";
        /// <summary>
        /// 课时
        /// </summary>
        public string lessonid = "";
        /// <summary>
        /// 单词
        /// </summary>
        public string word = "";
        /// <summary>
        /// 翻译
        /// </summary>
        public string translate = "";
        public DateTime AddTime;
        //添加
        public DateTime LastDayofStudy;
        //学习次数
        public int StudyNumber;
        /// <summary>
        /// 构造函数
        /// </summary>
        public TheWord(string bookid,string lessonid,string word,string translate)
        {
            this.bookid = bookid;
            this.lessonid = lessonid;
            this.word = word;
            this.translate = translate;
        }
    }
}
