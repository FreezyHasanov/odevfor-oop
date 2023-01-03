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
    public partial class Form4 : Form
    {
        public void go_back(object obj)
        {
            Application.Run(new Form1());
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ravager ramattra = new Ravager();

            vlcControl1.Visible = true;

            vlcControl1.Play(new Uri(ramattra.speak(@"C:\Users\hamid\Desktop\resim video\Ramattra konusma.mp4")));
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
