using System;
using System.Windows.Forms;

namespace Proteklo_i_tekuće_vrijeme
{
    public partial class Form1 : Form
    {
        DateTime pocetno;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pocetno = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();

            TimeSpan proteklo = DateTime.Now - pocetno;

            statusLabel1.Text = "Proteklo: " +
                proteklo.Hours.ToString("00") + ":" +
                proteklo.Minutes.ToString("00") + ":" +
                proteklo.Seconds.ToString("00");
        }

        private void statusLabel1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}