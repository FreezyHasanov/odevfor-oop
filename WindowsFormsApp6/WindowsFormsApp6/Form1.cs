using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(genji);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        public void genji(object obj)
        {
            Application.Run(new Form2());
        }
        public void zenyatta(object obj)
        {
            Application.Run(new Form3());

        }
        public void ramattra(object obj)
        {
            Application.Run(new Form4());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(zenyatta);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(ramattra);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
