using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egze_Marketing_Manager_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}"); 
            SendKeys.Send(textBox2.Text);
            SendKeys.Send("{Enter}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var newform = new Form3();
            newform.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("Quick SPM");
            SendKeys.Send("{Enter}");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var newform = new Form2();
            newform.Show();


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox3.Text);
            SendKeys.Send("{Enter}");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var newform = new Form4();
            newform.Show();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("m");
            SendKeys.Send("{Enter}");

        }
    }
}
