using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        public static System.Threading.Thread CurrentThread { get; }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 5)
            {
                panel1.Visible = true;
            }
            if (comboBox1.SelectedIndex != 5)
            {
                panel1.Visible = false;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                var p = new Process();
                p.StartInfo.FileName = "Lab3_1.exe";  // just for example, you can use yours.
                p.Start();

            }
            if (comboBox1.SelectedIndex == 7)
            {
                Form2 fm2 = new Form2();
                fm2.comboBox1.SelectedIndex = this.comboBox1.SelectedIndex;
                fm2.Left = this.Left;
                fm2.Top = this.Top;
                fm2.Show();
                this.Hide();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox2.AutoSize = false;
                textBox2.Height = 85;
                if (textBox1.Modified) textBox2.Clear();
                double xn, xk, x, x1, i; //начало, конец, шаг
                int j;
                xn = -3;
                xk = 3;
                int count = 0;
                double sum = 0;
                x = Convert.ToDouble(textBox1.Text);
                for (i = xn; i <= xk; i += x)
                {
                    count++;
                }
                double[] mas = new double[count];
                x1 = xn;
                for (j = 0; j <= count - 1; j++)
                {
                    mas[j] = Math.Round(-2 + Math.Sqrt(2 * Math.Pow((x1 + 1), 2) * (5 - x1)), 1);
                    if (j != count - 1)
                    {
                        textBox2.Text += ((mas[j].ToString()) + ";  ");
                        x1 += x;
                    }

                    else
                    {
                        textBox2.Text += (mas[j].ToString());
                        x1 += x;
                    }
                    sum += mas[j];

                }
                textBox3.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Вы ввели символ или не ввели ничего, введите число!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

