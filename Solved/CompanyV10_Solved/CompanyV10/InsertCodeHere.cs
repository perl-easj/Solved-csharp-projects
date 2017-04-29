using System;
using System.Collections.Generic;

namespace CompanyV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<Employee> company = new List<Employee>();

            Worker w1 = new Worker("James", 160, 140);
            Worker w2 = new Worker("Johanna", 120, 150);
            company.Add(w1);
            company.Add(w2);

            JuniorManager jm1 = new JuniorManager("Karen", 25000, 8000);
            JuniorManager jm2 = new JuniorManager("Henry", 28000, 7000);
            jm1.HoursWorkedThisMonth = 185;
            jm2.HoursWorkedThisMonth = 175;
            company.Add(jm1);
            company.Add(jm2);

            SeniorManager sm1 = new SeniorManager("Alfred", 45000, 12000);
            SeniorManager sm2 = new SeniorManager("Susan", 48000, 15000);
            sm1.PerformanceRatingThisMonth = 7;
            sm2.PerformanceRatingThisMonth = 5;
            company.Add(sm1);
            company.Add(sm2);

            foreach (Employee e in company)
            {
                Console.WriteLine("{0} receives a salary of {1} kr.", e.Name, e.SalaryPerMonth);
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}