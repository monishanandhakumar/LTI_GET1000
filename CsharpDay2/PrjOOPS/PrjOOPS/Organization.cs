using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjOOPS
{
   class Organization
    {
        //Properties 
       public string orgname { get; set; }
        //read -only property
        public int orgid { get; private set; } //get is public, set is private
       
        //read -only property
        public string registrationno { get; }

        string[] orglocation = { "chennai", "mumbai", "pune" }; //Array

        //default constructor
        internal  Organization()
        {
            Console.WriteLine("I am a default constructor");
        }
        //constuctor overloading
        internal Organization(string oname)
        {
            orgid = 1001;
            registrationno = "Org90";
            orgname = oname;

        }
        internal void Display()
        {
            Console.WriteLine("orgid:{0} || orgname:{1}|| registrationno:{2}", orgid, orgname, registrationno);
            foreach(string loc in orglocation)
            {
                Console.WriteLine(loc);
            }

        }

    }

    class CompanyInfo
    { 
        static void Main()
        {
            Organization organization = new Organization();
           // organization.id=100 //error since  the set accesor is private
            organization.orgname = "LTI";
            Console.WriteLine("calling by object 1");
            organization.Display();
             Console.WriteLine("calling by object2");
            Organization o2 = new Organization("ABC");
            o2.Display();

            Console.Read();

        }
    }
}
