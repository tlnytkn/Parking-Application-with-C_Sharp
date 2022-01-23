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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int flag = 1;
        private void button1_Click(object sender, EventArgs e)
        {
        
                if (textBox1.Text == Program.frm.btnA1.Text)
                {
                    Program.frm.btnA1.Text = "A1";
                    Program.frm.btnA1.BackColor = Color.Green;
                    flag = 0;
                    Program.frm.Show();
                    this.Hide();
                }
                
                if (textBox1.Text == Program.frm.btnA2.Text)
                {
                    Program.frm.btnA2.Text = "A2";
                    Program.frm.btnA2.BackColor = Color.Green;
                    flag = 0;
                    Program.frm.Show();
                    this.Hide();
                }

                if (textBox1.Text == Program.frm.btnA3.Text)
                {
                    Program.frm.btnA3.Text = "A3";
                    Program.frm.btnA3.BackColor = Color.Green;
                    flag = 0;
                    Program.frm.Show();
                    this.Hide();
                }

                if (textBox1.Text == Program.frm.btnA4.Text)
                {
                    Program.frm.btnA4.Text = "A4";
                    Program.frm.btnA4.BackColor = Color.Green;
                    flag = 0;
                    Program.frm.Show();
                    this.Hide();
                }

                if (textBox1.Text == Program.frm.btnA5.Text)
                {
                    Program.frm.btnA5.Text = "A5";
                    Program.frm.btnA5.BackColor = Color.Green;
                    flag = 0;
                    Program.frm.Show();
                    this.Hide();
                }

                if (textBox1.Text == Program.frm.btnA6.Text)
                { 
                    Program.frm.btnA6.Text = "A6";
                    Program.frm.btnA6.BackColor = Color.Green;
                    flag = 0;
                    Program.frm.Show();
                    this.Hide();
                }

                if (textBox1.Text == Program.frm.btnA7.Text)
                {
                    Program.frm.btnA7.Text = "A7";
                    Program.frm.btnA7.BackColor = Color.Green;
                    flag = 0;
                    Program.frm.Show();
                    this.Hide();
                }

                if (textBox1.Text == Program.frm.btnA8.Text)
                {
                    Program.frm.btnA8.Text = "A8";
                    Program.frm.btnA8.BackColor = Color.Green;
                    flag = 0;
                    Program.frm.Show();
                    this.Hide();
                }
                if (flag == 1)
                {
                    MessageBox.Show("Otoparkta böyle bir araç yoktur ! ");
                    Program.frm.Show();
                    this.Hide();
                }
            MessageBox.Show(maskedTextBox1.Text);


        }
    }
}
