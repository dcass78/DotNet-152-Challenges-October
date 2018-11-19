using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class GreetProgramUI
    {
        GreetRepository _greetRepo = new GreetRepository();
        Customer newCustomer = new Customer();
        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                      "\n1. Create new customer" +
                      "\n2. See customer list" +
                      "\n3. Update customer" +
                      "\n4. Delete customer" +
                      "\n5. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        PrintCustomerList();
                        break; //Show current list
                    case 3:
                        UpdateCustomer();
                        break;
                    case 4:
                        RemoveCustomerFromList();
                        break;
                    case 5:     //Exit
                        isRunning = false;
                        Console.WriteLine("Good bye");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void RemoveCustomerFromList()
        {
            List<Customer> customerList = _greetRepo.GetCustomerList();
            Console.WriteLine("FirstName\t");
            string firstName = Console.ReadLine();
            Console.WriteLine("LastName\t");
            string lastName = Console.ReadLine();
            foreach (Customer customer in customerList)
            {
                if(firstName == customer.FirstName && lastName == customer.LastName)
                {
                    _greetRepo.RemoveCustomerFromList(customer);
                }
            }
        }
        public void PrintCustomerList()
        {
            List<Customer> CustomerList = _greetRepo.GetCustomerList();
            Console.WriteLine("FirstName\t LastName\t Email\t CustomerType\t");
            Console.ReadLine();
        }
        public void AddCustomer()
        {
            Customer newCustomer = new Customer();
            Console.WriteLine("What is the customer type? Past, Potential or Present");
            Console.ReadLine();
            Console.WriteLine("What is the customer's first name?");
            Console.ReadLine();
            Console.WriteLine("What is the customer's last name?");
            Console.ReadLine();
            string input = Console.ReadLine().ToLower();
            bool isRunning = true;
            while (isRunning)
            {
                switch (input)
                { 
                    case "Past":   //Past, Potential, Present
                    newCustomer.CustomerType = CustomerType.Past;
                    Console.WriteLine("What is the customer's first name?");
                    newCustomer.FirstName = Console.ReadLine();
                    Console.WriteLine("What is the customer's last name?");
                    newCustomer.LastName = Console.ReadLine();
                    newCustomer.Email = "It's been a long time since we've heard from you, we want you back";
                    break;
                    case "Potential":
                    newCustomer.CustomerType = CustomerType.Potential;
                    Console.WriteLine("What is the customer's first name?");
                    newCustomer.FirstName = Console.ReadLine();
                    Console.WriteLine("What is the customer's last name?");
                    newCustomer.LastName = Console.ReadLine();
                    newCustomer.Email = "We currently have the lowest rates on Helicopter Insurance!";
                    break;
                    case "Present":
                    newCustomer.CustomerType = CustomerType.Present;
                    Console.WriteLine("What is the customer's first name?");
                    newCustomer.FirstName = Console.ReadLine();
                    Console.WriteLine("What is the customer's last name?");
                    newCustomer.LastName = Console.ReadLine();
                    newCustomer.Email = "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
                    break;
                    case "":     //Exit
                    isRunning = false;
                    Console.WriteLine("Good bye");
                    Console.ReadLine();
                    break;
                    //default:
                     //Console.WriteLine("Invalid response.");
                    //Console.ReadLine();
                }
            }
        }
        public void UpdateCustomer()
        {
            List<Customer> customerList = _greetRepo.GetCustomerList();
            Console.WriteLine("FirstName\t");
            string firstName = Console.ReadLine();
            Console.WriteLine("LastName\t");
            string lastName = Console.ReadLine();
            foreach (Customer customer in customerList)
            {
                if (firstName == customer.FirstName && lastName == customer.LastName)
                {
                    _greetRepo.UpdateCustomer(customer);
                }
            Console.ReadLine();
            break;
            }
        }
    }
}

