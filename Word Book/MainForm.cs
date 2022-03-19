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
        private void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task(()=>{
                for (int i = 1; i <= 20; i++)
                {
                    this.Invoke(new Action(()=> {
                        wordListView1.Add(new TheWord("Book", "Lesson", "Word" + i.ToString(), "µ¥´Ê" + i.ToString()));
                    }));
                    Thread.Sleep(100);
                }
            });
           task.Start();
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