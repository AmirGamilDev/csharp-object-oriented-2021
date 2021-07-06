using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvoiceLineItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void fillByInvoiceIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int invoiceID = Convert.ToInt32(invoiceIDToolStripTextBox.Text);
                this.invoicesTableAdapter.FillByInvoiceID(this.mMABooksDataSet.Invoices, invoiceID);
                if (invoicesBindingSource.Count > 0)
                {
                    this.invoiceLineItemsTableAdapter.FillByInvoiceID(this.mMABooksDataSet.InvoiceLineItems, invoiceID);
                }
                else
                {
                    MessageBox.Show("No invoice found with this ID. Please try again.",
                        "Invoice Not Found");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invoice ID must be an integer.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
