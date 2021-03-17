using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
    class Program
    {

        static void Main(string[] args)
        {
            //global::System.Object PizzaStores = StoreSingleton.Instance;
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
                    Console.WriteLine("Welcome back!");
                    //get customer name
                    name = GetName();

                    
                    Customer customer = ReadCustomerFromXML(name);
                    //OrderManager(bool isNewCustomer, Customer customer)
                    OrderManager(false, customer);
                    ////retrieve Customer customer from XML
                    //customerAddress = ReadAddressFromXML();

                    //verify correct information
                    //get order
                    done = true;
                }else if(input.Equals("2")){
                    Console.WriteLine("Welcome new customer!");
                    name = GetName();

                    customerAddress = CustomerAddress();
                    Customer customer = new Customer(name, customerAddress);
                    WriteCustomerToXML(customer);
                    
                    
                    OrderManager(true, customer);

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



        public static void OrderManager(bool isNewCustomer, Customer customer)
        {
            AStore store = GetStore();
            Order order = new Order(customer, store);
            //creates order with customer and store
            
            bool doneWithManager = false;
            
            if(isNewCustomer)
            {
                do
                {
                    Console.WriteLine("Would you like to:\n 1. Place Order\n 2. Quit");
                    switch (Console.ReadLine())
                    {
                        
                        case "1":
                            Console.WriteLine("Starting your order!");
                            bool hasNextPizza = true;
                            string iWantAPizza = "1";
                            do
                            {
                                if(iWantAPizza.Equals("1"))
                                    order.AddPizza(MakePizza());
                                Console.WriteLine("Would you like to add a pizza?\n 1. Yes\n 2. No");
                                iWantAPizza = Console.ReadLine();
                                switch(iWantAPizza)
                                {
                                    case "1":
                                        break;
                                    case "2":
                                        hasNextPizza = false;
                                        break;
                                    default:
                                        InvalidInput();
                                        break;
                                }
                            }while(hasNextPizza);
                            doneWithManager = true;
                            Console.WriteLine(order.PrintReciept());
                            WriteOrderToXML(order);
                            break;
                        //not done
                        case "2":
                            
                            Console.WriteLine("Have a nice day!");
                            System.Environment.Exit(1);
                            doneWithManager = true;
                            break;
                        default:
                            InvalidInput();
                        break;
                    }

                } while (!doneWithManager);
                
            }
            else
            {
            
                do
                {
                    Console.WriteLine("Would you like to:\n 1. Place Order\n 2. View Order History\n 3. Quit");
                    switch (Console.ReadLine())
                    {
                        //not done
                        case "1":
                            Console.WriteLine("Starting your order!");
                            bool hasNextPizza = true;
                            string iWantAPizza = "1";
                            do
                            {
                                if(iWantAPizza.Equals("1"))
                                    order.AddPizza(MakePizza());
                                Console.WriteLine("Would you like to add a pizza?\n 1. Yes\n 2. No");
                                iWantAPizza = Console.ReadLine();
                                switch(iWantAPizza)
                                {
                                    case "1":
                                        break;
                                    case "2":
                                        hasNextPizza = false;
                                        break;
                                    default:
                                        InvalidInput();
                                        break;
                                }
                            }while(hasNextPizza);
                            doneWithManager = true;
                            Console.WriteLine(order.PrintReciept());
                            WriteOrderToXML(order);
                            break;
                        //not done
                        case "2":
                            Console.WriteLine("Retrieving Order History. . .");
                            ReadOrderFromXML(customer.GetCustomerName());
                            doneWithManager = true;
                            break;
                        //done
                        case "3":
                            Console.WriteLine("Have a nice day!");
                            System.Environment.Exit(1);
                            doneWithManager = true;
                            break;
                        default:
                            InvalidInput();
                        break;
                    }
                } while (!doneWithManager);
                
                
            }
        }


        //needs work
        public static AStore GetStore()
        {
            Console.WriteLine("What is the store for the order? \n1. Chris's Pizza\n2. Chicago Pizza\n3. Detroit Pizza\n4.New York Pizza");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    return new ChrisPizzaStore();
                
                case "2":
                    return new ChicagoPizzaStore();
                
                case "3":
                    return new DetroitPizzaStore();
                
                case "4":
                    return new NewYorkPizzaStore();
                
                default:
                    InvalidInput();
                    break;
            }
            return new ChrisPizzaStore();
        }
        //done
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
                InvalidInput();
            }
            return address;
        }
 
         
        //not done
        
        
        public static APizza MakePizza()
        {
            bool done = false;
            string size = "";
            double sizeCost = 0.0;
            string input;
            string crustType = "";
            double crustCost = 1.0;
            do
            {
                Console.WriteLine("What size pizza do you want?\n1. Small\n2. Medium\n3.Large");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        size = "small";
                        sizeCost = 5.0;
                        done = true;
                        break;
                    case "2":
                        size = "medium";
                        sizeCost = 6.0;
                        done = true;
                        break;
                    case "3":
                        size = "large";
                        sizeCost = 7.0;
                        done = true;
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (!done);
            done = false;
            do
            {
                Console.WriteLine("What kind of crust do you want?\n1. Garlic and Herb\n2. Cheese Stuffed\n3. Regular");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        crustType = "Garlic and Herb";
                        
                        
                        done = true;
                        break;
                    case "2":
                        crustType = "Cheese Stuffed";
                        
                        done = true;
                        break;
                    case "3":
                        crustType = "Regular";
                        crustCost = 0.0;
                        done = true;
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (!done);
            done = false;
            APizza pizza = null;
            do
            {
                Console.WriteLine("What kind of pizza do you want?\n1. Meat Lovers\n2. Vegan Pizza\n3. Veggie Pizza\n4. Build your own pizza");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        pizza = new MeatPizza(crustType, crustCost, size, sizeCost);
                        
                        done = true;
                        break;
                    case "2":
                        pizza= new VeganPizza(crustType, crustCost, size, sizeCost);
                        
                        done = true;
                        break;
                    case "3":
                        pizza = new VeggiePizza(crustType, crustCost, size, sizeCost);
                        
                        done = true;
                        break;
                    case "4":
                        pizza = new CustomPizza(crustType, crustCost, size, sizeCost);
                        
                        
                        done = true;
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (!done);
            Console.WriteLine("This pizza cost: $" + pizza.GetPizzaCost());
            return pizza;
        }

        public static void InvalidInput()
        {
            Console.WriteLine("Not a valid input");
        }


        //!Not done
        /**NEEDS VERIFICATION**/
        public static Customer ReadCustomerFromXML(string name)
        {
            Address address = new Address();
            Customer customer = new Customer(name, address);
            //create file storage
            FileStorage fs = new FileStorage();
            //open file path
            // & create list of all customers
            List<Customer> customers = new List<Customer>(fs.ReadFromXML<Customer>(customer._GetCustomerPath()));
            //find customer who's name matches the string
            int index = customers.FindIndex(a => a.CustomerName == name);
            //return matched customer
            customer = customers[index];
            
            return customer;
        }
        public static void WriteCustomerToXML(Customer customer)
        {
            FileStorage fs = new FileStorage();
            List<Customer> customers = new List<Customer>();
            customers.Add(customer);
            fs.WriteToXML<Customer>(customers, customer._GetCustomerPath());
        }
        
        public static void ReadOrderFromXML(string name)
        {
            
            Order order = new Order();
            
            FileStorage fs = new FileStorage();
            //fetch a list of all orders
            List<Order> orders = new List<Order>(fs.ReadFromXML<Order>(order._GetOrderPath()));
            //compare and return the receipt for all orders who contain the customer's name.
            foreach(Order anOrder in orders)
            {
                if(anOrder.GetCustomerName() == name)
                {
                    Console.WriteLine(anOrder.PrintReciept());
                }
            }          
        }
        public static void WriteOrderToXML(Order order)
        {
            FileStorage fs = new FileStorage();
            List<Order> orders = new List<Order>(){order};
            fs.WriteToXML<Order>(orders, order._GetOrderPath());
        }        
    }
}
