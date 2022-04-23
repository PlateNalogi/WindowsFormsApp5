using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form2 f22;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] StlArr;
            string rl;
            double[] x;
            double z,sum = 0, pr = 1;
            rl = textBox1.Text;
            StlArr = rl.Split(';');
            x = new double[StlArr.Length];
            z = Convert.ToDouble(f22.textBox1.Text);
            for (int i = 0; i < x.Length;i++)
                x[i] = Convert.ToDouble(StlArr[i]);
            if (f22.checkBox1.Checked)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (f22.radioButton1.Checked && x[i] >= z) sum += x[i];
                    if(f22.radioButton2.Checked && x[i] >= z) sum += x[i];
                }
            }
            if (f22.checkBox2.Checked)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (f22.radioButton1.Checked && x[i] >= z) pr*= x[i];
                    if (f22.radioButton2.Checked && x[i] >= z) pr*= x[i];
                }
            }
            label6.Text = "" + sum;
            label5.Text = "" + pr;
        }
    }
}
