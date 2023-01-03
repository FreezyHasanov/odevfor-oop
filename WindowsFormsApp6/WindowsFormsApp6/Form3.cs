using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void go_back(object obj)
        {
            Application.Run(new Form1());
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Omnic zenyatta = new Omnic();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(zenyatta.meditate(@"C:\Users\hamid\Desktop\resim video\Y2Mate_is_Zenyatta_Emote_Animations_Overwatch_OyOIXtZ97EM_720p_1655591971828.mp4")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Omnic zenyatta = new Omnic();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(zenyatta.speak(@"C:\Users\hamid\Desktop\resim video\zenyatta konusma .mp4")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Omnic zenyatta = new Omnic();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(zenyatta.dance(@"C:\Users\hamid\Desktop\resim video\zenyata dans .mp4")));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(go_back);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
