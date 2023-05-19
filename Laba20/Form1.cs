using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double a) ||
                    !double.TryParse(textBox2.Text, out double b) ||
                    !double.TryParse(textBox3.Text, out double c))
                {
                    MessageBox.Show("Введіть коректні коефіцієнти рівняння.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    double discriminant = b * b - 4 * a * c;

                    if (discriminant < 0)
                    {
                        throw new Exception("Дійсних коренів не існує.");
                    }

                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    result.Text = $"x1 = {x1}, x2 = {x2}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функція обчислює корінь квадратного рівняння", "Задвання");
        }
    }
}
