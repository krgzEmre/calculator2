using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);

            double sayı2 = Convert.ToDouble(textBox2.Text);

            if (checkBox1.Checked == true)
            {
                double sonuc = sayı1 + sayı2;

                listBox1.Items.Add(sayı1 + "+" + sayı2 + "=" + sonuc);

            }

            if (checkBox3.Checked == true)
            {
                double sonuc = sayı1 - sayı2;

                listBox1.Items.Add(sayı1 + "-" + sayı2 + "=" + sonuc);

            }

            if (checkBox4.Checked == true)
            {
                double sonuc = sayı1 * sayı2;

                listBox1.Items.Add(sayı1 + "*" + sayı2 + "=" + sonuc);

            }

            if (checkBox2.Checked == true)
            {
                double sonuc = sayı1 / sayı2;
                listBox1.Items.Add(sayı1 + "/" + sayı2 + "=" + sonuc);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
