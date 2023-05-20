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
    public partial class Form6 : Form
    {
        public static Form6 instance;
        public Form6()
        {
            InitializeComponent();
            instance = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
