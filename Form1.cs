using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Froms
{
    public partial class Form1 : Form
    {
        sbyte countYes = 0;
        sbyte countNo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                countYes++;
            } else countYes--;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                countNo++;
            } else countNo--;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox4.Checked = false;
                countYes++;
            }
            else countYes--;
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox3.Checked = false;
                countNo++;
            } else countNo--;
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox6.Checked = false;
                countYes++;
            } else countYes--;
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox5.Checked = false;
                countNo++;
            } else countNo--;
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox8.Checked = false;
                countYes++;
            } else countYes--;
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox7.Checked = false;
                countNo++;
            } else countNo--;
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox10.Checked = false;
                countYes++;
            }
            else countYes--;
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox9.Checked = false;
                countNo++;
            }
            else countNo--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count Yes: " + countYes + "\n" + "Count No: " +countNo);
        }
    }
}
