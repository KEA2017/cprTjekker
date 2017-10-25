using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cprTjekker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string birth = maskedTextBox1.Text;
            List<int> birthNum = new List<int>();
            for(int i = 0; i < 8; i++)
            {
                try
                {
                    birthNum.Add(Convert.ToInt16(birth.Substring(i, 1)));
                }
                catch
                {

                }
            }
            int result = birthNum[0] * 4 + birthNum[1] * 3 + birthNum[2] * 2 + birthNum[3] * 7 + birthNum[4] * 6 + birthNum[5] * 5;
            for(int i = 0; i <10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (radioButton1.Checked)
                        {
                            for (int n = 1; n < 10; n += 2)
                            {
                                if ((result + i * 4 + j * 3 + k * 2 + n) % 11 == 0)
                                {
                                    listBox1.Items.Add(birth + " " + i + j + k + n);
                                }
                            }
                        }
                        else if (radioButton2.Checked)
                        {
                            for (int n = 0; n < 10; n += 2)
                            {
                                if ((result + i * 4 + j * 3 + k * 2 + n) % 11 == 0)
                                {
                                    listBox1.Items.Add(birth + " " + i + j + k + n);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Show your dingdong");
                            i += 1000;
                            j += 1000;
                            k += 1000;
                            break;                            
                        }
                    }
                }
            }


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
