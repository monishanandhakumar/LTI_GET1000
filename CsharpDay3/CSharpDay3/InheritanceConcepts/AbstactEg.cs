using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
   abstract class RbI
    {
      public  int noofbanksundercontrol { get; set; }
      abstract  public int HomeLoan(); //abstract method

        //non-abstract method
        internal string Rules()
        {
            return "Pancard is Manditory for all customer";
        }

    }

   class SBI:RbI
    {
        public override int HomeLoan()
        {
            Console.WriteLine("TO apply homeloan read the following rules : aadhar card , salary slip is mandatory");
            return 9;
        }
    }
    class ICICI:RbI
    {
        public override int HomeLoan()
        {
            Console.WriteLine("ICICI Home Loan Percentage:");
            return 10;
        }
    }
    class AbstactEg
    {
        static void Main()
        {
            //RbI robj = new RbI(); //cant create object for abstact class
            /*  SBI sobj = new SBI();
              Console.WriteLine(sobj.Rules() );   //rbi
              sobj.noofbanksundercontrol = 10; //rbi
              Console.WriteLine(sobj.HomeLoan() );  //sbi
              ICICI iobj = new ICICI();
              Console.WriteLine(iobj.HomeLoan());*/

            //Run-time polymorphism
            RbI robj;
            robj= new SBI();
            Console.WriteLine(robj.Rules());   //rbi
            robj.noofbanksundercontrol = 10; //rbi
            Console.WriteLine(robj.HomeLoan());  //sbi
            robj = new ICICI();
            Console.WriteLine(robj.HomeLoan());

        }
    }
}
