using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            tBox.Text = Convert.ToString(Convert.ToInt32(tBox.Text) + 1);
        }

        private void btnMultiply2_Click(object sender, EventArgs e)
        {
            tBox.Text = Convert.ToString(Convert.ToInt32(tBox.Text) * 2);
        }
    }
}
