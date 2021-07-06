using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBasicsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Product cs15 = new Product("CS15", "Murach's C# 2015", 56.50M);
            Product vb15 = new Product { Code = "VB15", Description = "Murach's Visual Basic 2015", Price = 56.50M };

            string cs15DisplayText = cs15.GetDisplayText(",");
            string vb15DisplayText = vb15.GetDisplayText("-");

            MessageBox.Show(cs15DisplayText);
            MessageBox.Show(vb15DisplayText);

            // this will use getter for Code property
            string cs15ProductCode = cs15.Code;

            // this will use the setter for Code property
            cs15.Code = "Some other code";
        }
    }
}
