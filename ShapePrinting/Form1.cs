using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printing
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();

            shapes.Add(new Square("Green", 5));
            shapes.Add(new Circle("Blue", 3));
            shapes.Add(new Rectangle("Red", 4, 7));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 16, FontStyle.Bold);

            StringFormat drawFormat = new StringFormat
            {
                Alignment = StringAlignment.Center
            };

            e.Graphics.DrawString("Shape Info", printFont, Brushes.Black,
                e.MarginBounds, drawFormat);

            drawFormat = new StringFormat
            {
                Alignment = StringAlignment.Near
            };

            printFont = new Font("Courier New", 12, FontStyle.Bold);

            string heading = "\n\n";
            heading += "Shape No".PadRight(20);
            heading += "Shape Type".PadRight(20);
            heading += "Area";

            e.Graphics.DrawString(heading, printFont, Brushes.Black,
                e.MarginBounds, drawFormat);

            string shapesInfo = "\n\n\n";

            int count = 1;

            foreach(Shape s in shapes)
            {
                shapesInfo += "\n";
                shapesInfo += count.ToString().PadRight(20);
                shapesInfo += s.GetType().Name.PadRight(20);
                shapesInfo += Math.Round(s.Area, 2);

                count++;
            }

            printFont = new Font("Courier New", 12, FontStyle.Regular);

            e.Graphics.DrawString(shapesInfo, printFont, Brushes.Black,
                e.MarginBounds, drawFormat);
        }
    }
}
