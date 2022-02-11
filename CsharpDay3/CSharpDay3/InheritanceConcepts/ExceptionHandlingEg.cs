using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    //Custom exception or userdefined exception
    class AgeNotValid:ApplicationException
    {
        public AgeNotValid(string message):base(message)
        {

        }

    }
    class ApplyVoterID
    {
        string status;
        
        public string VoterId(int age)
        {
            if(age > 18)
            {
                status = "Eligible";
            }
            else
            {
                throw new AgeNotValid("Age should be greater than 18 to apply voter id");
            }


            return status;
        }
    }
    class ExceptionHandlingEg
    {

        static void Main()
        {
            float salary,perdaysalary;
            string[] chooselocation = { "Chennai", "Bangalore", "Mumbai" };
            ApplyVoterID applyVoterID = new ApplyVoterID();
            try
            {
                Console.WriteLine("Enter your salary per month");
                salary = float.Parse(Console.ReadLine()); //unboxing
                perdaysalary = salary / 30;
                Console.WriteLine("perdaysalary:{0}", perdaysalary);
                // Console.WriteLine(chooselocation[3]);

                applyVoterID.VoterId(16);


            }
           
           catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Please choose the correct index!!!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("close all port");
            }
        }

    }
}
