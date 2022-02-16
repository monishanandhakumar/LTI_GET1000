using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Ado.net
{
    class DAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
    public SqlConnection GetConnection()
        {
            con = new SqlConnection(
               "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = Northwind; Integrated Security = true");
            con.Open();
            return con;
        }
    //procedure without parameter
        internal void TenProductProcedure()
        {
            try
            {
                con = GetConnection();
                                      //procedure name in sql server
                cmd = new SqlCommand("Ten Most Expensive Products", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr[0]+" "+dr[1]);
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                con.Close();
            }
        }

        //Procedure with parameters
        internal void CustOrderProcedure(string cid)
        {
            try
            {
                con = GetConnection();
                //procedure name in sql server
                cmd = new SqlCommand("CustOrdersOrders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", cid);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                Console.WriteLine("-------------------------------------");
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1]+" "+dr[2] );
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                con.Close();
            }
        }


    }
    class StoredProcedure
    {
        static void Main()
        {
           /* DAO dAO = new DAO();
            dAO.TenProductProcedure();
            Console.WriteLine("Enter the Customer Id");
            string cusid = Console.ReadLine();
            dAO.CustOrderProcedure(cusid);*/
        }
    }
}
