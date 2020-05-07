using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class zeno : Form
    {
        private double _xachill;
        private double _xtort;
        private double _vachill;
        private double _vtort;
        private double _s;
        private double _t;
        private double[] tortrecloc = new double[4];
        private double[] achrecloc = new double[4];
        



        public zeno()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer2.Interval = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                _xachill = double.Parse(textBox1.Text, NumberStyles.AllowDecimalPoint);
                _xtort = double.Parse(textBox2.Text, NumberStyles.AllowDecimalPoint);
                achrecloc[0] = _xachill;
                 
                var xtort = _xtort;
                tortrecloc[0] = _xtort;

                if (_xachill < 0)
                {
                    textBox1.Clear();
                    MessageBox.Show("Не-не-не, кожаный мешок, не пойдет");
                }

                if (xtort < 0)
                {
                    textBox2.Clear();
                    MessageBox.Show("Не-не-не, кожаный мешок, не пойдет");
                }

                if (_xachill >= xtort)
                {
                    _xachill = 0;
                    _xtort = 0;
                    MessageBox.Show("Давай еще раз, мне не нравятся эти исходники");
                }

                textBox3.Text = ($"{_xachill}");
                textBox4.Text = ($"{_xtort}");
                

            }
            catch
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        public void button2_Click(object sender, EventArgs e)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }



            private void timer1_Tick(object sender, EventArgs e)
            {

                try
                {
                    _vachill = double.Parse(textBox5.Text, NumberStyles.AllowDecimalPoint);
                    _vtort = double.Parse(textBox6.Text, NumberStyles.AllowDecimalPoint);
                }
                catch
                {
                    _vachill = 2;
                    _vtort = 1;
                    textBox5.Text = Convert.ToString(_vachill);
                    textBox6.Text = Convert.ToString(_vtort);
                }

                _s = _xtort - _xachill;
                _t = _s / _vachill;
                _xachill = _xtort;
                _xtort = _xtort + _t * _vtort;
                
            }


            private void button3_Click(object sender, EventArgs e)
            {
                timer1.Enabled = false;
            }

            private void button4_Click(object sender, EventArgs e)
            {
                timer1.Enabled = false;
                _t = 0;
                _xachill = 0;
                _xtort = 0;
                textBox1.Text = Convert.ToString(_xachill);
                textBox2.Text = Convert.ToString(_xtort);
                textBox3.Text = Convert.ToString(_xachill);
                textBox4.Text = Convert.ToString(_xtort);
                
            }

      

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            pictureBox2.Refresh();
            Bitmap mb = new Bitmap(pictureBox2.Width, pictureBox2.Height);


            Brush ach = new SolidBrush(Color.Black);
            Brush tor = new SolidBrush(Color.DarkGreen);
            int intach = Convert.ToInt32(_xachill);
            e.Graphics.FillRectangle(ach, intach, 200, 20, 100);
            int inttort = Convert.ToInt32(_xtort);
            e.Graphics.FillRectangle(tor, inttort, 200, 50, 45);

        }

        
    }
    }


