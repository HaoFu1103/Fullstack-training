﻿using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = CreateCustomers();

            Console.WriteLine("Customers:\n");
            foreach (Customer c in customers)
                Console.WriteLine(c);

        }

        static List<Customer> CreateCustomers()
        {
            return new List<Customer>
            {
            new Customer(1) { Name = "Maria Anders",     City = "Berlin"    },
            new Customer(2) { Name = "Laurence Lebihan", City = "Marseille" },
            new Customer(3) { Name = "Elizabeth Brown",  City = "London"    },
            new Customer(4) { Name = "Ann Devon",        City = "London"    },
            new Customer(5) { Name = "Paolo Accorti",    City = "Torino"    },
            new Customer(6) { Name = "Fran Wilson",      City = "Portland"  },
            new Customer(7) { Name = "Simon Crowther",   City = "London"    },
            new Customer(8) { Name = "Liz Nixon",        City = "Portland"  }
        };
            }

    }
}
