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
    public partial class Form8 : Form
    {
        public static Form8 instance;
        public Form8()
        {
            InitializeComponent();
            instance = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            form.Show();
        }
    }
}
