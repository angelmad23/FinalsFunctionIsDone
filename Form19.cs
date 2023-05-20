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
    public partial class Form19 : Form
    {
        public static Form19 instance;
        public Form19()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form20 form = new Form20();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 form = new Form17();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
        }
    }
}
