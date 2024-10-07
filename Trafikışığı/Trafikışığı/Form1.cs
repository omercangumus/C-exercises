using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafikışığı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {



            sayac++;


            label1.Text = sayac.ToString();




            if (sayac == 10)
            {
                pictureBox4.Visible = true;

                pictureBox2.Visible = false;

                pictureBox3.Visible = false;

                pictureBox1.Visible = false;

                button1.Enabled = false;



            }


            if (sayac == 30)
            {

                pictureBox4.Visible = false;

                pictureBox2.Visible = false;

                pictureBox3.Visible = false;

                pictureBox1.Visible = true;

                button1.Enabled = false;
            }


            if (sayac == 70)
            {

                pictureBox4.Visible = false;

                pictureBox2.Visible = true;

                pictureBox3.Visible = false;

                pictureBox1.Visible = false;

                button1.Enabled = false;
            }



            if (sayac == 100)
            {

                pictureBox4.Visible = false;

                pictureBox2.Visible = false;

                pictureBox3.Visible = true;

                pictureBox1.Visible = false;

                button1.Enabled = false;
            }

            if (sayac == 150)
            {

                pictureBox4.Visible = false;

                pictureBox2.Visible = false;

                pictureBox3.Visible = false;

                pictureBox1.Visible = true;


                button1.Enabled = false;




            }

            if (sayac == 170)
            {

                pictureBox4.Visible = true;

                pictureBox2.Visible = false;

                pictureBox3.Visible = false;

                pictureBox1.Visible = false;

                timer1.Stop();

                button1.Enabled = false;
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {


            timer1.Start();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
