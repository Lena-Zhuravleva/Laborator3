using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 5)
            {
                Form1 fm2 = new Form1();
                fm2.comboBox1.SelectedIndex = this.comboBox1.SelectedIndex;
                fm2.Left = this.Left;
                fm2.Top = this.Top;
                fm2.Show();
                this.Hide();
            }

            if (comboBox1.SelectedIndex == 0)
            {
                var p = new Process();
                p.StartInfo.FileName = "Lab3_1.exe";
                p.Start();

            }
            if (comboBox1.SelectedIndex == 7)
            {
                panel1.Visible = true;
            }
            if (comboBox1.SelectedIndex != 7)
            {
                panel1.Visible = false;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int n;
                if (textBox1.Modified) textBox2.Clear();
                n = Int32.Parse(textBox1.Text);
                if (n != 0)
                {
                    int k = 1;
                    double sum = 0;
                    double res;
                    int n1 = n;
                    while (k <= n)
                    {
                        res = Math.Pow(k, n1);
                        sum += res;
                        k++;
                        n1--;
                    }

                    textBox2.Text = sum.ToString();
                }
                if (n == 0)
                {
                    MessageBox.Show("Вы ввели 0, введите число больше 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("Вы ввели символ или не ввели ничего, введите число!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

    }  
}
