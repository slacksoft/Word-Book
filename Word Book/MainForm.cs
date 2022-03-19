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
namespace EnglishPrison
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            wordListView1.Add(new TheWord("Book","Lesson","Word"+i.ToString(),"µ¥´Ê" + i.ToString()));
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wordListView1.RemoveChecked();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            wordListView1.Clean();
        }
    }
}