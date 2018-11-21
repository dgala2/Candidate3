using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaqasConsoleApplication
{
    class Customer
    {
        public Customer(Customer customer)
        {
            
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public GenderType Gender { get; set; }  

    }

    enum GenderType
    {
        Male,
        Female,
        All
    };
}
