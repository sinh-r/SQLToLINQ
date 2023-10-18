using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLToLINQ
{
    public static class CustomerProcessor
    {
        public static List<Customer> FetchAllCustomers()
        {
            return new()
            {
                new()
                {
                    Id = 1,
                    Name = "Rishabh Sinha",
                    Address = "Ghaziabad"
                },
                new()
                {
                    Id = 2,
                    Name = "Abhay Rana",
                    Address = "Sahibabad"
                },
                new()
                {
                    Id = 3,
                    Name = "Aman Singh",
                    Address = "Noida"
                },
                new()
                {
                    Id = 4,
                    Name = "Preeti Verma",
                    Address = "Raipur"
                },
                new()
                {
                    Id = 5,
                    Name = "Tanya Srivastava",
                    Address = "Delhi"
                },
                new()
                {
                    Id = 6,
                    Name = "Govind Kumar",
                    Address = "Ghaziabad"
                }
            };
        }

        public static void PrintAllCustomers(List<Customer> customers)
        {
            foreach(var customer in customers)
            {
                Console.WriteLine($"{customer.Id}\t{customer.Name}\t{customer.Address}");
            }
        }

        public static void PrintCustomerName(List<Customer> customers)
        {
            var customerNames = customers.Select(x => x.Name).ToList();

            foreach(var customer in customerNames)
            {
                Console.WriteLine(customer);
            }
        }

        public static void PrintCustomerNameAndAddress(List<Customer> customers)
        {
            var customerNameAndAddresses = customers.Select(x => new { x.Name, x.Address }).ToList();

            foreach(var customer in customerNameAndAddresses)
            {
                Console.WriteLine($"{customer.Name}\t{customer.Address}");
            }
        }

        public static void PrintCustomer(List<Customer> customers, int id)
        {
            var customer = customers.Where(x =>  x.Id == id).FirstOrDefault();

            Console.WriteLine($"{customer?.Id}\t{customer?.Name}\t{customer?.Address}");
        }

        public static void PrintTopNCustomers(List<Customer> customers, int n)
        {
            var topNCustomer = customers.Take(n);

            foreach(var customer in topNCustomer)
            {
                Console.WriteLine($"{customer?.Id}\t{customer?.Name}\t{customer?.Address}");
            }
        }

        public static void PrintDistinctAddressCustomers(List<Customer> customers)
        {
            var distinctAddressCustomers = customers.Distinct();

            foreach(var customer in distinctAddressCustomers)
            {
                Console.WriteLine($"{customer.Id}\t{customer.Name}\t{customer.Address}");
            }
        }
    }
}
