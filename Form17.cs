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
    public partial class Form17 : Form
    {
        public static Form17 instance;
        public Form17()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            form.Show();
        }
    }
}
