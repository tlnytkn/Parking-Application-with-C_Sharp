using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark
{
    public partial class Form1 : Form
    {
        public int konum=9;
        
        



        public Form1()
        {
            InitializeComponent();
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
            switch (konum)
            {
                case 0:
                    btnA1.Text = plaka;
                    btnA1.BackColor = Color.Red;
                    
                    break;

                case 1:
                    btnA2.Text = plaka;
                    btnA2.BackColor = Color.Red;
                    break;

                case 2:
                    btnA3.Text = plaka;
                    btnA3.BackColor = Color.Red;

                    break;

                case 3:
                    btnA4.Text = plaka;
                    btnA4.BackColor = Color.Red;
                    break;

                case 4:
                    btnA5.Text = plaka;
                    btnA5.BackColor = Color.Red;
                    break;

                case 5:
                    btnA6.Text = plaka;
                    btnA6.BackColor = Color.Red;
                    break;

                case 6:
                    btnA7.Text = plaka;
                    btnA7.BackColor = Color.Red;
                    break;

                case 7:
                    btnA8.Text = plaka;
                    btnA8.BackColor = Color.Red;
                    break;

                default:
                    
                    break;
            }*/


        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            
        }

        private static void btnA1_Click(object sender, EventArgs e)
        {

        }
    }
}
