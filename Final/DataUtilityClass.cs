using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Final
{
    static class DataUtilityClass
    {
        static System.Data.SqlClient.SqlConnection conn = null;

        static void ConnectToDB()
        {
            conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Final.mdf;Integrated Security=True";
            conn.Open();
        }

        static public List<ClassCustomer> GetEntries()
        {
            List<ClassCustomer> listEntries = new List<ClassCustomer>();
            try
            {
                ConnectToDB();
                string sql = "SELECT * FROM Customers ORDER BY Id";
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, conn);
                System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listEntries.Add(new ClassCustomer(Convert.ToInt16(reader["Id"]),reader["FName"].ToString(), reader["LName"].ToString(), reader["Address"].ToString(), reader["City"].ToString(), reader["State"].ToString(), reader["ZipCode"].ToString(), reader["Phone"].ToString()));
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("An error has occurred: {0}", ex);
                listEntries = null;
            }
            CloseDBConn();
            return listEntries;
        }

        static public void AddEntry(ClassCustomer Customer)
        {
            try
            {
                ConnectToDB();
                string sql = "insert into Customers(FName, LName, Address, City, State, ZipCode, Phone) values('" + Customer.FirstName + "', '" + Customer.LastName + "', '" + Customer.Address + "', '" + Customer.City + "', '" + Customer.State + "', '" + Customer.ZipCode + "', '" + Customer.Phone + "')";
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, conn);
                command.ExecuteNonQuery();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Debug.WriteLine("An error has occurred: {0}", ex);
            }
            CloseDBConn();
        }

        static public void AddEntryOrder(ClassOrder order)
        {
            try
            {
                ConnectToDB();
                string sql = "insert into Orders(CustomerID, Date, P1, P2, P3, Subtotal, Tax, Total) values ('" + order.CustomerID + "', '" + order.Date + "', '" + order.P1 + "', '" + order.P2 + "', '" + order.P3 + "', '" + order.Subtotal + "', '" + order.Tax + "', '" + order.Total + "')";
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, conn);
                command.ExecuteNonQuery();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Debug.WriteLine("An error has occurred: {0}", ex);
            }
            CloseDBConn();
        }

        static public List<ClassCustomerOrder> GetOrderEntries()
        {
            List<ClassCustomerOrder> listEntries = new List<ClassCustomerOrder>();
            try
            {
                ConnectToDB();
                string sql = "SELECT o.Id, o.Date,o.Total,o.CustomerID, c.Id, c.FName, c.LName FROM Orders o, Customers c WHERE c.Id=o.CustomerID";
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, conn);
                System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listEntries.Add(new ClassCustomerOrder(
                        new ClassCustomer(Convert.ToInt16(reader["Id"]), 
                        reader["FName"].ToString(), reader["LName"].ToString()), 
                        new ClassOrder(Convert.ToInt16(reader["Id"]),
                        reader["Date"].ToString(), 
                        Convert.ToDecimal(reader["Total"]))));
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("An error has occurred: {0}", ex);
                listEntries = null;
            }
            CloseDBConn();
            return listEntries;
        }

        public static ClassCustomerOrder SelectOrderByID(int id)
        {
            ClassCustomerOrder OrderToReturn = null;
            try
            {
                ConnectToDB();
                string sql = "SELECT o.Id, o.Date, o.P1, o.P2, o.P3, o.Subtotal, o.Tax, o.Total, o.CustomerID, c.Id, c.FName, c.LName, c.Address, c.City, c.State, c.ZipCode, c.Phone FROM Orders o, Customers c WHERE c.Id=o.CustomerID AND o.Id=" + id;
                //string sql = "SELECT * FROM Books where BookID=" + id;
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, conn);
                System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OrderToReturn = new ClassCustomerOrder(
                        new ClassCustomer(Convert.ToInt16(reader["Id"]),
                        reader["FName"].ToString(), reader["LName"].ToString(),
                        reader["Address"].ToString(), reader["City"].ToString(),
                        reader["State"].ToString(), reader["ZipCode"].ToString(),
                        reader["Phone"].ToString()),
                        new ClassOrder(Convert.ToInt16(reader["Id"]),
                        reader["Date"].ToString(), Convert.ToInt16(reader["P1"]),
                        Convert.ToInt16(reader["P2"]), Convert.ToInt16(reader["P3"]),
                        Convert.ToDecimal(reader["Subtotal"]), Convert.ToDecimal(reader["Tax"]),
                        Convert.ToDecimal(reader["Total"])));
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Debug.WriteLine("An error has occurred: {0}", ex);
            }
            CloseDBConn();
            return OrderToReturn;
        }


        static public void CloseDBConn()
        {
            conn.Close();
        }
    }
}