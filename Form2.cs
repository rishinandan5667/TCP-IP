using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                int b1 = Convert.ToInt32(textBox1.Text);
                int b2 = Convert.ToInt32(textBox2.Text);
                int b3 = Convert.ToInt32(textBox3.Text);
                int b4 = Convert.ToInt32(textBox4.Text);

                if (b1 > 0 && b1 <= 255)
                {
                    if (b2 >= 0 && b2 <= 255)
                    {
                        if (b3 >= 0 && b3 <= 255)
                        {
                            if (b4 >= 0 && b4 <= 255)
                            {
                                MessageBox.Show("This is perfect IP Address");
                            }
                        }
                    }

                }
                else
                    MessageBox.Show("This is not an IP Address");
            }
            catch(Exception er)
            {

            }
        }
    }
}
