using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; //1.Install the package from nuget package manager

namespace Ado.net
{
    class Shipper
    {
        //value nullable type
        int? no = null;
        //reference nullable type
        string? name;
        public int shipperid { get; set; }
        public string companyname { get; set; }
        public string phone { get; set; }

        public void GetShipper()
        {
            Console.WriteLine("Enter the companyname or shippername" );
            companyname = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            phone= Console.ReadLine();
        }

       
    }
    class ConnectedArchitecture
    {

        static void Main()
        {
            //creatng object for shipperclass
            Shipper shipper = new Shipper();
            //2.create Sqlconnection object
            SqlConnection con=null;
            //create sqlcommand object
            SqlCommand cmd = null;

            try
            {
                //3. Windows Authentication
                con = new SqlConnection(
              "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = Northwind; Integrated Security = true");

                //Sql server authentication
                // con = new SqlConnection(
                // "Data Source= DESKTOP-U8J1M3C\\MSSQLSERVER01;Initial Catalog=Northwind;User ID=sa;Password=newuser123#");

                //4.open connection
                con.Open();

                //call Getshipper method
                // shipper.GetShipper();

                //Insert 
                /* cmd = new SqlCommand("insert into Shippers(CompanyName,Phone) values(@sname,@sphone)", con);
                 cmd.Parameters.AddWithValue("@sname", shipper.companyname);
                 cmd.Parameters.AddWithValue("@sphone", shipper.phone);
                int i= cmd.ExecuteNonQuery();
                 Console.WriteLine("Records Inserted is {0}",i);*/

                //Delete

                /*   Console.WriteLine("Enter the shipper name or company name to be deleted");
                   shipper.companyname = Console.ReadLine();
                   cmd = new SqlCommand("delete from Shippers where CompanyName=@cname", con);
                   cmd.Parameters.AddWithValue("@cname", shipper.companyname);
                   int i = cmd.ExecuteNonQuery();
                   Console.WriteLine("Records Deleted is {0}", i);

                   cmd.Parameters.Clear();*/

                //select

                /* SqlDataReader dr;
                 cmd = new SqlCommand("select * from Shippers", con);
                dr= cmd.ExecuteReader();
                 while(dr.Read())
                 {
                     //  Console.WriteLine(dr[0]+"  "+dr[1]+" "+dr[2]);

                     Console.WriteLine(dr["CompanyName"] + "  " + dr["Phone"] );
                 }*/

                //Update
               /* Console.WriteLine("Enter the id to which the record to be updated");
                shipper.shipperid = Convert.ToInt32(Console.ReadLine());
                shipper.GetShipper();
                cmd = new SqlCommand("update Shippers set CompanyName=@cname ,Phone=@cphone where ShipperID=@id", con);
                cmd.Parameters.AddWithValue("@id", shipper.shipperid);
                cmd.Parameters.AddWithValue("@cname", shipper.companyname);
                cmd.Parameters.AddWithValue("@cphone", shipper.phone);
                int i = cmd.ExecuteNonQuery();
                Console.WriteLine("Records updated is {0}", i);

                cmd.Parameters.Clear();*/

                //Scalar Value
                cmd = new SqlCommand("select count(ShipperId) from Shippers", con);
                Console.WriteLine("No of Shipper:{0}", cmd.ExecuteScalar()); //returns integer


                cmd = new SqlCommand("select CompanyName from Shippers where ShipperId=1 ", con);
                Console.WriteLine("CompanyName:{0}", cmd.ExecuteScalar()); //returns string
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
}
