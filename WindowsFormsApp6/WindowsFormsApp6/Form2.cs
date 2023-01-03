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
    public partial class Form2 : Form
    {
        public void openmdi(object obj)
        {
            Application.Run(new Form1());
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human genji = new Human();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(genji.speak(@"C:\Users\hamid\Desktop\resim video\genji konusma.mp4")));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Human genji = new Human();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(genji.dance(@"C:\Users\hamid\Desktop\resim video\genji dans.mp4")));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openmdi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
