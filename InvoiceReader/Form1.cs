using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice invoice = InvoiceDB.GetInvoice(int.Parse(txtInvoiceId.Text));

                if (invoice != null)
                {
                    txtInvoiceDate.Text = invoice.InvoiceDate.ToString().Substring(0, 10);
                    txtInvoiceTotal.Text = invoice.InvoiceTotal.ToString("c2");
                }
                else
                {
                    MessageBox.Show("No Invoice with that Invoice ID");

                    txtInvoiceDate.Text = "";
                    txtInvoiceTotal.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }
    }
}
