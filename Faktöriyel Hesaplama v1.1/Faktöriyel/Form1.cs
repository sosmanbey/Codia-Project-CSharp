using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktöriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        int faktöriyel = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 5; i++)
            {
                faktöriyel = faktöriyel * i;
                label1.Text = faktöriyel.ToString();
            }
        }
    }
}
