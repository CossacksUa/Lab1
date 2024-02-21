using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (txtX.TextLength != 0 && txtY.TextLength != 0)
            {
                double X = Convert.ToDouble(txtX.Text);
                double Y = Convert.ToDouble(txtY.Text);
                double res = (1 + Math.Sin(Math.Sqrt(X + 1))) / (Math.Cos(12 * Y - 4));
                lebRes.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void butOk2_Click(object sender, EventArgs e)
        {
            if (txtX1.TextLength != 0 && txtY1.TextLength != 0 && txtX2.TextLength != 0 && txtY2.TextLength != 0)
            {
                double X1 = Convert.ToDouble(txtX1.Text);
                double Y1 = Convert.ToDouble(txtY1.Text);
                double X2 = Convert.ToDouble(txtX2.Text);
                double Y2 = Convert.ToDouble(txtY2.Text);
                double res2 = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
                lebRes2.Text = res2.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtX1_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY1_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY1_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtX2_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY2_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtX3_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY3_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void butOk4_Click(object sender, EventArgs e)
        {
            if (txtX1_4.TextLength != 0 && txtY1_4.TextLength != 0 && txtX2_4.TextLength != 0 && txtY2_4.TextLength != 0 && txtX3_4.TextLength != 0 && txtY3_4.TextLength != 0)
            {
                double X1 = Convert.ToDouble(txtX1_4.Text);
                double Y1 = Convert.ToDouble(txtY1_4.Text);
                double X2 = Convert.ToDouble(txtX2_4.Text);
                double Y2 = Convert.ToDouble(txtY2_4.Text);
                double X3 = Convert.ToDouble(txtX3_4.Text);
                double Y3 = Convert.ToDouble(txtY3_4.Text);
                double S = 0.5 * Math.Abs(X1 * (Y2 - Y3) + X2 * (Y3 - Y1) + X3 * (Y1 - Y2));
                double A = (X2 - X1);
                double AB = (Y2 - Y1);
                double B = (X3 - X2);
                double BA = (Y3 - Y2);
                if (A == B)
                {
                    string reset = $"Знаходяться на одній прямій бо вектор AB({A},{AB})=BC({B},{BA})";
                    lebRes4.Text = reset.ToString();
                }
                else
                {

                    lebRes4.Text = S.ToString();
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtA_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }
        private void butOk3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtA.Text) && !string.IsNullOrEmpty(txtD.Text) && !string.IsNullOrEmpty(txtC.Text))
            {
                int a = int.Parse(txtA.Text);
                int c = int.Parse(txtC.Text);
                int d = int.Parse(txtD.Text);

                bool isSquareAndCube = (c == a * a) && (d == a * a * a);

                lebRes3.Text = isSquareAndCube.ToString();
            }
            else
            {
                MessageBox.Show("Помилка");
            }
        }

        private void butOk7_Click(object sender, EventArgs e)
        {
            // Введений рядок
            string inputString = "Вилучити частину символьного рядка, взятого в дужки (разом з дужками).";

            // Виклик функції для вилучення тексту в дужках
            string result = RemoveTextInParentheses(inputString);

            lebRes7.Text = (result);

            Console.ReadLine();
        }

        static string RemoveTextInParentheses(string input)
        {
            // Використання регулярного виразу для знаходження тексту в дужках
            string pattern = @"\([^)]*\)";
            string result = Regex.Replace(input, pattern, "");

            return result;
        }
    }
    }


