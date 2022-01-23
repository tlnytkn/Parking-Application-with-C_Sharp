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
    public partial class Form2 : Form
    {
        public string plaka;
        string[] plakas = new string[8];
        public int sure,tutar,konum;


        public Form2()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            
            
            plaka = textBox1.Text;
            sure = Convert.ToInt32(textBox2.Text);
            tutar = sure * 5;
            if (checkBox1.Checked==true)
            {
                tutar += 15;
            }
            if (checkBox2.Checked == true)
            {
                tutar += 20;

            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Program.frm.btnA1.Text = plaka;
                    Program.frm.btnA1.BackColor = Color.Red;
                    break;

                case 1:
                    Program.frm.btnA2.Text = plaka;
                    Program.frm.btnA2.BackColor = Color.Red;
                    break;

                case 2:
                    Program.frm.btnA3.Text = plaka;
                    Program.frm.btnA3.BackColor = Color.Red;
                    break;

                case 3:
                    Program.frm.btnA4.Text = plaka;
                    Program.frm.btnA4.BackColor = Color.Red;
                    break;

                case 4:
                    Program.frm.btnA5.Text = plaka;
                    Program.frm.btnA5.BackColor = Color.Red;
                    break;

                case 5:
                    Program.frm.btnA6.Text = plaka;
                    Program.frm.btnA6.BackColor = Color.Red;
                    break;

                case 6:
                    Program.frm.btnA7.Text = plaka;
                    Program.frm.btnA7.BackColor = Color.Red;
                    break;

                case 7:
                    Program.frm.btnA8.Text = plaka;
                    Program.frm.btnA8.BackColor = Color.Red;
                    break;   
            }
            Program.frm.Show();
            this.Hide();
        }
    }
}