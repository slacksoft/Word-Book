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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            List<TheWord> theWords = new List<TheWord>();
            for (int i = 0;i<100;i++) {
                theWords.Add(new TheWord("","","Hello"+i.ToString(),"ÄãºÃ"+i.ToString()));
            }
            wordListViewFull1.SetValue(theWords);
        }

        private void wordListView1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {

      
        }

        private void wordListViewFull1_Item_Change()
        {
            MessageBox.Show(wordListViewFull1.wordListView.CheckedItem.word.word);
        }
    }
}