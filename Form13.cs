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
    public partial class Form13 : Form
    {
        public static Form13 instance;
        public Form13()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
