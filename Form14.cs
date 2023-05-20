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
    public partial class Form14 : Form
    {
        public static Form14 instance;
        public Form14()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            form.Show();
        }
    }
}
