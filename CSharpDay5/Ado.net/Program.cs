using System;
using Get1000ClassLibrary;
namespace Ado.net
{
    class Test
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t
            TaxCalculation tobj = new TaxCalculation();
            Console.WriteLine( tobj.Calculator(78000)); 
            Console.WriteLine("Hello World!");

            DAO dAO = new DAO();
            dAO.TenProductProcedure();
            Console.WriteLine("Enter the Customer Id");
            string cusid = Console.ReadLine();
            dAO.CustOrderProcedure(cusid);
        }
    }
}
