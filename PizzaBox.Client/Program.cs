using System;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerInteraction();
        }

        public static void PlayWithStore()
        {
            
            foreach(var store in StoreSingleton.Instance.Stores)
            {
                Console.WriteLine(store);
            }
        }

        public static void CustomerInteraction()
        {
            
            bool done = false;
            string name;
            Address customerAddress = new Address();
            do{
                Console.WriteLine("Are you an existing customer? \n  1. Yes \n  2. No\n  3. Quit");
                string input = Console.ReadLine();
                if(input.Equals("1")){
                    
                    //get customer name
                    name = GetName();
                    
                    ////retrieve Customer customer from XML
                    //customerAddress = ReadAddressFromXML();
                    
                    //verify correct information
                        //get order
                    done = true;
                }else if(input.Equals("2")){
                    Console.WriteLine("Welcome new customer!");
                    name = GetName();

                    customerAddress = CustomerAddress();
                    
                    //start getting customer's order
                    done = true;
                }else if(input.Equals("3")){
                    done = true;
                }else{
                    Console.WriteLine("Not a valid input!");
                }
            }while(!done);
            Console.WriteLine("Come back soon!");
            System.Environment.Exit(1);
        }
        public static string GetName(){
            Console.WriteLine("What is the name for the order?");
            return Console.ReadLine();
        }
        public static Address CustomerAddress()
        {
            Console.WriteLine("Please enter your address (00 Street Name City State 00000)");
            String reader = Console.ReadLine();
            String[] readerSplitter = reader.Split(' ');
            Address address = new Address();
            if(readerSplitter.Length == 6)
            {
                address = new Address(int.Parse(readerSplitter[0]), (readerSplitter[1] + ' ' 
                    + readerSplitter[2]), readerSplitter[3], readerSplitter[4], int.Parse(readerSplitter[5]));
            }else if(readerSplitter.Length == 7){
                address = new Address(int.Parse(readerSplitter[0]), (readerSplitter[1] + ' ' 
                    + readerSplitter[2]), int.Parse(readerSplitter[3]), readerSplitter[4], readerSplitter[5], int.Parse(readerSplitter[6]));
            }else{
                Console.WriteLine("Not a valid address");
            }
            return address;
        }
        /// <summary>
        /// Manages the order:
        /// 1. Confirms whether to place or view order history
        /// if(place order)
        ///     Open a new order
        ///     Confirm store
        ///     build pizzas
        ///     place and save the order
        /// if(view order history)
        ///     Retrieve orders matching their name
        ///     print up to 10 previous orders
        /// </summary>
        /// <returns></returns>
        public static Order OrderManager()
        {
            
            Order order = new Order();
            bool doneWithManager = false;
            do{
                Console.WriteLine("Would you like to:\n1. Place Order\n2. View Order History\n3. Quit");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Starting your order!");
                        doneWithManager = !doneWithManager;
                    break;
                    case "2":
                        Console.WriteLine("Retrieving Order History. . .");
                        doneWithManager = !doneWithManager;
                    break;
                    case "3":
                        Console.WriteLine("Have a nice day!");
                        System.Environment.Exit(1);
                        doneWithManager = !doneWithManager;
                    break;
                    default:
                        Console.WriteLine("Not a valid input");
                    break;
      }
            }while(!doneWithManager);
            //Order.cs needs work
            return order;
        }
        public static Address ReadAddressFromXML()
        {
            Address address = new Address();
            //some code
            return address;
        }
    }
}
