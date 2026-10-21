using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet_Lab4
{
    public partial class victorform : Form
    {
        public victorform()
        {
            InitializeComponent();
        }

        public string GetKeyword()
        {
            return textBox1.Text.Trim();
        }
        private void victorform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
