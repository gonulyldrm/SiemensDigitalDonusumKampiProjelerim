using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Configuration;
using WpfExamplee.DatabaseConnection;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace WpfExamplee.Methods
{
    internal class Method
    {
        public static bool ProductAdd(string urunad, int fiyat, int adet)
        {
            SqlConnection conn = new SqlConnection(Database.GetConnectionString);
            string sql = "INSERT INTO Products (ProductName,UnitPrice,UnitsInStock) VALUES (@name,@Fiyat,@Adet)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            bool result = false;
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", urunad);
                    cmd.Parameters.AddWithValue("@Fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@Adet", adet);
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static bool ProductDelete(int id)
        {
            SqlConnection conn = new SqlConnection(Database.GetConnectionString);
            string sql = "DELETE FROM Products WHERE ProductID = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            bool result = false;
            try
            {


                conn.Open();

                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static bool Login(string txtfirstname,string txtlastname)
        {

            bool result = false;
            SqlConnection conn = new SqlConnection(Database.GetConnectionString);
            conn.Open();
            SqlCommand komut = new SqlCommand("Select * from Employees", conn);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (txtfirstname == reader["FirstName"].ToString().TrimEnd() && txtlastname == reader["LastName"].ToString().TrimEnd())
                {
                    result = true;
                    Window1 main = new Window1();
                    main.ShowDialog();
                    

                    break;
                }
                
            }
            conn.Close();
            return result;  
        }        
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Database.GetConnectionString;
            
            SqlCommand komut = new SqlCommand();
            string sql = "SELECT ProductID, ProductName, UnitPrice,UnitsInStock FROM Products";
          
         
            try
            {
                komut = new SqlCommand(sql, conn);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    products.Add(new Product(Convert.ToInt32(dr["ProductID"]), dr["ProductName"].ToString(),Convert.ToInt32( dr["UnitPrice"]),Convert.ToInt32(dr["UnitsInStock"])));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return products;
        }
        public static List<Product> GetProductsNoStock()
        {
            List<Product> products = new List<Product>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Database.GetConnectionString;

            SqlCommand komut = new SqlCommand();
            string sql = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products where UnitsInStock=0";

            try
            {
                komut = new SqlCommand(sql, conn);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    products.Add(new Product(Convert.ToInt32(dr["ProductID"]), dr["ProductName"].ToString(), Convert.ToInt32(dr["UnitPrice"]), Convert.ToInt32(dr["UnitsInStock"])));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return products;
        }
        public static List<Product> GetProductUnitPrice50_80()
        {
            List<Product> products = new List<Product>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Database.GetConnectionString;

            SqlCommand komut = new SqlCommand();
            string sql ="SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products where UnitPrice > 50 and UnitPrice<80";

            try
            {
                komut = new SqlCommand(sql, conn);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    products.Add(new Product(Convert.ToInt32(dr["ProductID"]), dr["ProductName"].ToString(), Convert.ToInt32(dr["UnitPrice"]), Convert.ToInt32(dr["UnitsInStock"])));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return products;
        }
        public static List<Product> GetProductsUnitPrice20()
        {
            List<Product> products = new List<Product>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Database.GetConnectionString;

            SqlCommand komut = new SqlCommand();
            string sql = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products where UnitPrice < 20 ";

            try
            {
                komut = new SqlCommand(sql, conn);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    products.Add(new Product(Convert.ToInt32(dr["ProductID"]), dr["ProductName"].ToString(), Convert.ToInt32(dr["UnitPrice"]), Convert.ToInt32(dr["UnitsInStock"])));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return products;
        }
        public static List<Product> GetProductsUnitPrice20plus()
        {
            List<Product> products = new List<Product>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Database.GetConnectionString;

            SqlCommand komut = new SqlCommand();
            string sql = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products where UnitPrice > 20 ";

            try
            {
                komut = new SqlCommand(sql, conn);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    products.Add(new Product(Convert.ToInt32(dr["ProductID"]), dr["ProductName"].ToString(), Convert.ToInt32(dr["UnitPrice"]), Convert.ToInt32(dr["UnitsInStock"])));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return products;
        }
    }
}
