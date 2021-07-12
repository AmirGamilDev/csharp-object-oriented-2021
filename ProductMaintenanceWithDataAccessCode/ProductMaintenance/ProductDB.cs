using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductMaintenance
{
    public static class ProductDB
    {
        public static Product GetProduct(string code)
        {
            SqlConnection connection = MMABooksDB.GetConnection();

            string selectStatement
                = "SELECT ProductCode, Description, UnitPrice "
                + "FROM Products "
                + "WHERE ProductCode = @Code";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@Code", code);
            
            try
            {
                connection.Open();

                SqlDataReader productReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (productReader.Read())
                {
                    Product product = new Product();
                    product.Code = productReader["ProductCode"].ToString();
                    product.Description = productReader["Description"].ToString();
                    product.Price = (decimal)productReader["UnitPrice"];

                    return product;
                }
                else
                {
                    return null;
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
        }

        public static bool AddProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertStatement =
                "INSERT Products " +
                "(ProductCode, Description, UnitPrice) " +
                "VALUES (@Code, @Description, @Price)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@Code", product.Code);
            insertCommand.Parameters.AddWithValue("@Description", product.Description);
            insertCommand.Parameters.AddWithValue("@Price", product.Price);

            try
            {
                connection.Open();

                int count = insertCommand.ExecuteNonQuery();

                if (count > 0)
                    return true;
                else
                {
                    return false;
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
        }

        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection connection = MMABooksDB.GetConnection();

            string updateStatement =
                "UPDATE Products SET " +
                "Description = @NewDescription, " +
                "UnitPrice = @NewPrice " +
                "WHERE ProductCode = @OldCode " +
                "AND Description = @OldDescription " +
                "AND UnitPrice = @OldPrice";

            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@NewDescription", newProduct.Description);
            updateCommand.Parameters.AddWithValue("@NewPrice", newProduct.Price);
            updateCommand.Parameters.AddWithValue("@OldCode", oldProduct.Code);
            updateCommand.Parameters.AddWithValue("@OldDescription", oldProduct.Description);
            updateCommand.Parameters.AddWithValue("@OldPrice", oldProduct.Price);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();

                if (count > 0)
                    return true;
                else
                {
                    return false;
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
        }

        public static bool DeleteProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();

            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProductCode = @Code " +
                "AND Description = @Description " +
                "AND UnitPrice = @Price";
            
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);

            deleteCommand.Parameters.AddWithValue("@Code", product.Code);
            deleteCommand.Parameters.AddWithValue("@Description", product.Description);
            deleteCommand.Parameters.AddWithValue("@Price", product.Price);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();

                if (count > 0)
                    return true;
                else
                {
                    return false;
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
        }
    }
}
