﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lissajue
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private bool stopClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            
            try
            {
                double y0, x0, wx, wy, δφ, t = 0;
                y0 = double.Parse(textBox1.Text);
                x0 = double.Parse(textBox2.Text);
                wx = double.Parse(textBox3.Text);
                wy = double.Parse(textBox4.Text);
                δφ = double.Parse(textBox5.Text);
                while (t < 100)
                {
                    double x = x0 * Math.Cos(wx * t);
                    double y = y0 * Math.Cos(wy * t + δφ);
                    chart1.Series[0].Points.AddXY(x, y);
                    t += 0.01;
                }
                
            }
            catch (ArgumentException)
            {
                MessageBox.Show(@"Bad arguments!");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl( (e.KeyChar)))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl( (e.KeyChar)))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox3.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl( (e.KeyChar)))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox4.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl( (e.KeyChar)))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox5.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl( (e.KeyChar)))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {}

        private void textBox5_TextChanged(object sender, EventArgs e)
        {}

        private void button2_Click(object sender, EventArgs e)
        {
            stopClicked = true;
            MessageBox.Show(@"You click stop...");
        }
    }
}