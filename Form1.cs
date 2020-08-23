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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Enterfirstnumber = Convert.ToInt32(textBox1.Text);
                int Entersecondnumber = Convert.ToInt32(textBox2.Text);

                int result = Enterfirstnumber + Entersecondnumber;

                MessageBox.Show("Addition result = " + result.ToString());
            }
            catch(Exception er)
            {

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
