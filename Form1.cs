using System;
using System.Windows.Forms;

namespace Froms
{
    public partial class Form1 : Form
    {
        // iteratory zliczające odpowiedzi w formularzu
        private int countYes = 0;
        private int countNo = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void validation(int x)
        {
            CheckBox[] all = new CheckBox[10]
            {
                checkBox1, // 0
                checkBox2, // 1
                checkBox3, // 2
                checkBox4, // 3
                checkBox5, // 4
                checkBox6,
                checkBox7,
                checkBox8,
                checkBox9,
                checkBox10,
            };

            // jeżeli parametr jest równy 0 lub jest liczbą nieparzystą to
            if (x % 2 != 1 || x == 0)
            {
                // sprawdza czy jego element w tablicy jest zaznaczony i jeżeli tak to
                if (all[x].Checked == true)
                {
                    // nadaje kolejnemu elemntowi tablicy właściwość false
                    // (służy odznaczeniu drugiego elementu jeżeli jesten jest już zaznaczony) 
                    all[x + 1].Checked = false;
                    // jeżeli element z naszym parametrem jest true to dodaje 1 do interator countYes
                    countYes++;
                }
                // jeżeli nie to odbiera naszemu iteratorowi 1
                else countYes--;
            }
            // jeżeli parametr jest parzysty to
            else
            {
                // sprawdza czy jego element w tablicy jest zaznaczony i jeżeli tak to
                if (all[x].Checked == true)
                {
                    // nadaje WCZEŚNIEJSZEMU elemntowi tablicy właściwość false
                    all[x - 1].Checked = false;
                    countNo++;
                }
                else countNo--;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            // paremetr metody odpowiada indexowi tablicy checkboxów
            validation(0);
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            validation(1);
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            validation(2);
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            validation(3);
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            validation(4);
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            validation(5);
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            validation(6);
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            validation(7);
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            validation(8);
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            validation(9);
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (countYes + countNo < 5)
            {
                MessageBox.Show("Ankieta niewypełniona kompletnie!");
            }
            else
            {
                //MessageBox.Show("Count Yes: " + countYes + "\n" + "Count No: " + countNo);
                Form2 f2 = new Form2();

                switch (countYes)
                {
                    case 5:
                        f2.pictureBox1.Image = global::Froms.Properties.Resources.face_wink;
                        break;
                    case 4:
                        f2.pictureBox1.Image = global::Froms.Properties.Resources.Face_smile;
                        break;
                    case 1:
                        f2.pictureBox1.Image = global::Froms.Properties.Resources.face_sad;
                        break;
                    case 0:
                        f2.pictureBox1.Image = global::Froms.Properties.Resources.face_sad_sweating;
                        break;
                    default:
                        f2.pictureBox1.Image = global::Froms.Properties.Resources.face_plain;
                        break;
                }

                f2.ShowDialog();
            }

        }
    }
}
