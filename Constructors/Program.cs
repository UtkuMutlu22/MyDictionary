using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer1 = new Customer { Id = 1, FirstName = "utku", LastName = "Mutlu", City = "Edirne" };
            Customer customer2 = new Customer(2, "Arzu", "Mutlu", "İstanbul");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Fuat";
            customer3.LastName = "Mutlu";
            customer3.City = "Ankara";


            


        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }



        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
