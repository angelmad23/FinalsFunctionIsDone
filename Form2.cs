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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }
    }
}
