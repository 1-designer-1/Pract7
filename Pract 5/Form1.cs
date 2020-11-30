﻿using System;
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
            MessageBox.Show("Практическая работа № 6\n" +
                "Серегин Денис \n" +
                "ИСП-31\n" +
                "Задание \n" +
                "Использовать класс Pair (пара четных чисел). Разработать операцию перемножения пар(а, b) * (с, d) = (а * c, b * d). " +
                "Разработать операцию инкремента для удвоения пары чисел.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();


        }
        private void заполнтьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Pair pair1 = new Pair(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Pair pair2 = new Pair(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            Pair Multiply = Pair.Multiply(pair1, pair2);
            textBox5.Text = ("(" + Multiply.First + " ; " + Multiply.Second + ")").ToString();
            Pair Multiply1 = Pair.Multiply2(pair1);
            textBox6.Text = ("(" + Multiply1.First + " ; " + Multiply1.Second + ")").ToString();
            Pair Multiple = pair1 * pair2;
            textBox7.Text = ("(" + Multiple.First + " ; " + Multiple.Second + ")").ToString();
            Pair Multiple2 = pair1++;
            textBox8.Text = ("(" + Multiple2.First + " ; " + Multiple2.Second + ")").ToString();
        }


    }
}
