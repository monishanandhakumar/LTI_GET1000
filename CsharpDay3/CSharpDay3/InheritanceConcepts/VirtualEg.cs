using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    class Mobile
    {
       public string isbn { get; set; }
       public virtual void Clock()
        {
            Console.WriteLine("I am a general clock method of mobile class");
        }

        public virtual  void EyeSensor()
        {
            Console.WriteLine("I am a eye Sensormethod of mobile class");
        }

    }

    class Samsung : Mobile
    {
        public override void Clock()
        {
            Console.WriteLine("I am a world clock method of samsung class");
        }

        public string SamsungPay()
        {
            return "amount";
        }
    }
    class VirtualEg
    {
        static void Main()
        {
            Mobile mobile = new Mobile();
            mobile.Clock();
            mobile.EyeSensor();
            Samsung samsung = new Samsung();
            samsung.Clock();
            Console.WriteLine(samsung.SamsungPay());
        }
    }
}
