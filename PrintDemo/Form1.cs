using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrintHelloWorld_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch(Win32Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 16, FontStyle.Bold);

            e.Graphics.DrawString("Hello world!", printFont, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
        }
    }
}
