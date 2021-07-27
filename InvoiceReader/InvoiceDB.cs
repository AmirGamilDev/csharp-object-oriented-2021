using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceReader
{
    public class InvoiceDB
    {
        public static Invoice GetInvoice(int invoiceId)
        {
            SqlConnection connection = MMABooksDB.GetConnection();

            string selectStatement
                = "SELECT InvoiceID, InvoiceDate, InvoiceTotal "
                + "FROM Invoices "
                + "WHERE InvoiceID = @InvoiceId";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@InvoiceId", invoiceId);

            try
            {
                connection.Open();

                SqlDataReader invoiceReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (invoiceReader.Read())
                {

                    Invoice invoice = new Invoice(
                            Convert.ToInt32(invoiceReader["InvoiceID"]),
                            DateTime.Parse(invoiceReader["InvoiceDate"].ToString()),
                            decimal.Parse(invoiceReader["InvoiceTotal"].ToString())
                        );

                    // operation of converting to DateTime is equiavlent to:
                    //object invoiceDateFromDatabase = invoiceReader["InvoiceDate"];
                    //string invoiceDateFromDatabaseString = invoiceDateFromDatabase.ToString();
                    //DateTime dateTime = DateTime.Parse(invoiceDateFromDatabaseString);
                    //
                    //Note: Could also cast to DateTime (i.e. (DateTime)invoiceReader["InvoiceDate"]) but you
                    // *may* run into issues.  Always keep in mind the above technique in case you do run into issues.


                    return invoice;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return null;
        }
    }
}
