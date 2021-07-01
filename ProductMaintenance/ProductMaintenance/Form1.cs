using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show($"A concurrency error occurred: {ex.Message}", ex.GetType().ToString());
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.productsBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Number}: {ex.Message}", ex.GetType().ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Number}: {ex.Message}", ex.GetType().ToString());
            }
        }
    }
}
