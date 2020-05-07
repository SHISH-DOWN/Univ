using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form euklid = new Evklid();
            euklid.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form zenon = new zeno();
            zenon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form salgs = new algs();
            salgs.Show();

        }
    }
}
