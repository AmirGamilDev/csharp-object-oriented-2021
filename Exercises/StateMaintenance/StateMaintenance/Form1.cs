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

namespace StateMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.statesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show($"A concurrency error occurred: {ex.Message}", ex.GetType().ToString());
                this.statesTableAdapter.Fill(this.mMABooksDataSet.States);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.statesBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Number}: {ex.Message}", ex.GetType().ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.States' table. You can move, or remove it, as needed.
            try
            {
                this.statesTableAdapter.Fill(this.mMABooksDataSet.States);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Number}: {ex.Message}", ex.GetType().ToString());
            }
        }

        private void statesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = $"A data error occurred.\nRow: {row}\nError: {e.Exception.Message}";

            MessageBox.Show(errorMessage, "Data error");
        }
    }
}
