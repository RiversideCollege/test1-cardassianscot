using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //addded a bit here
            label1.Text="Hello";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bye";
        }
    }
}
