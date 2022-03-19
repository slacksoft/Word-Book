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
    public class TheWord
    {
        /// <summary>
        /// 课本
        /// </summary>
        public string book = "";
        /// <summary>
        /// 课时
        /// </summary>
        public string lesson = "";
        /// <summary>
        /// 单词
        /// </summary>
        public string word = "";
        /// <summary>
        /// 翻译
        /// </summary>
        public string translate = "";
        /// <summary>
        /// 构造函数
        /// </summary>
        public TheWord(string book,string lesson,string word,string translate)
        {
            this.book = book;
            this.lesson = lesson;
            this.word = word;
            this.translate = translate;
        }
    }
}
