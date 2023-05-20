using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figma
{
    public partial class Form11 : Form
    {
        public static Form11 instance;
        public Form11()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 form = new Form17();
            form.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
