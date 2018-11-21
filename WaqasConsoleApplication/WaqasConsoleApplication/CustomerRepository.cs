using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaqasConsoleApplication
{
    class CustomerRepository : ICustomerRepository
    {
        public double AgeOfCustomers(List<Customer> customers, GenderType? gender)
        {

            double age = 0;
            int count = 0;


            foreach (Customer c in customers)
            {

                if (c.Gender == gender || gender == null)
                {
                    count++;
                    age += CalculateTotalAge(c.DateOfBirth);
                }


            }

            return age / count;
        }


        private int CalculateTotalAge(DateTime dob)
        {
        
            var age = DateTime.Today.Year - dob.Year;
            // Go back to the year the person was born in case of a leap year
            if (dob > DateTime.Today.AddYears(-age))
                age--;

            return age;
        }


    }
}
