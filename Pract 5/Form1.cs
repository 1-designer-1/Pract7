using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 7\n" +
                "Серегин Денис \n" +
                "ИСП-31\n" +
                "Задание \n" +
                "Использовать класс Pair (пара четных чисел). Определить производный класс треугольник RightAngled с полями-катетами." +
                "Определить методы вычисления гипотенузы и площади треугольника.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();



        }
        private void заполнтьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RightAngled rightAngled = new RightAngled(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            int resuiltGupotez = rightAngled.Gupotenyza();
            textBox3.Text = resuiltGupotez.ToString();
            double resultPloshad = rightAngled.Ploshad();
            textBox4.Text = resultPloshad.ToString();





        }
    }
}
