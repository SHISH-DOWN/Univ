using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Evklid : Form
    {
        private int _a0, _c, _b0, _a1, _b1;
        string _sa, _sb;

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                int.TryParse(textBox1.Text, out _a0);
                _a1 = _a0;
                int.TryParse(textBox2.Text, out _b0);
                _b1 = _b0;
                _sa = _a0.ToString();
                _sb = _b0.ToString();
                textBox3.Text = "Готов к следующему шагу, переменные записаны";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                var a = _a0; var b = _b0;

                var iWhile = 0;
                while (iWhile == 0)
                {
                    if (a != 0 && b != 0)
                    {
                        if (a >= b)
                        {
                            _c = a % b;
                            if (_c == 0)
                            {
                                alertoorres = $"НОД чисел " + _sa + " и " + _sb + " равен " + b;
                                textBox3.Text = alertoorres;
                                iWhile = 1;

                            }
                            else
                            {


                                a = b;
                                b = _c;
                            }


                        }
                        else
                        {
                            _c = b % a;
                            if (_c == 0)
                            {
                                alertoorres = $"НОД чисел " + _sa + " и " + _sb + " равен " + a;
                                textBox3.Text = alertoorres;
                                iWhile = 1;

                            }
                            else
                            {

                                int bswaptoa = a;
                                b = a;
                                a = _c;
                            }

                        }
                    }
                    else
                    {
                        alertoorres = "Одна из переменных равна 0, или введены некорректные величины";
                        textBox3.Text = alertoorres;
                        iWhile = 1;
                    }
                }
            }
        }

        string alertoorres;



        



        
        public Evklid()
        {
            InitializeComponent();
        }


    }
}
