using System;

namespace Get1000ClassLibrary
{
    public class TaxCalculation
    {
         public double Calculator(int salary)
        {
            double tax;
            int annualsalary = (salary * 12);
            if(annualsalary>300000)
            {
                tax = annualsalary * 0.1;
            }
            else
            {
                tax = 0;
            }
            return tax;
        }
    }
}
