using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaqasConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();

            customers.AddRange(new Customer[]
            {
                "Joe Bloggs", new DateTime(1980, 4, 1), GenderType.Male

            });


            ICustomerRes resp= 

        }
    }
}
