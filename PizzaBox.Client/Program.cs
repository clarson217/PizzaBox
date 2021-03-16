using System;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;
using PizzaBox.Domain.Abstracts;


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

                    /*customerAddress = ReadAddressFromXML(name);
                     * !!!NEED TO WORK ON STORAGE!!!*/
                    Customer customer = new Customer(name, customerAddress);
                    OrderManager(true, customer);
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
        //done
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
                Console.WriteLine(order.PrintReciept());
                //Take from existing customer when finished with that part
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
                            order.AddPizza(MakePizza());
                            doneWithManager = true;
                            break;
                        //not done
                        case "2":
                            Console.WriteLine("Retrieving Order History. . .");

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
                //Order.cs needs work
                //return order;
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
        /// <summary>
        /// Manages the order:
        /// ift they are not a new customer:
        ///     Confirms whether to place or view order history
        ///         if(place order)
        ///             Open a new order
        ///             Confirm store
        ///             build pizzas
        ///              place and save the order
        ///         if(view order history)
        ///             Retrieve orders matching their name
        ///             print up to 10 previous orders
        /// If they are a new customer:
        ///     Gathers customer information
        /// </summary>
        /// <returns></returns>
         
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
                        /*MeatPizza meatPizza*/ pizza = new MeatPizza(crustType, crustCost, size, sizeCost);
                        //APizza pizza = meatPizza;
                        done = true;
                        break;
                    case "2":
                        /*VeganPizza veganPizza*/ pizza= new VeganPizza(crustType, crustCost, size, sizeCost);
                        //APizza pizza = veganPizza;
                        done = true;
                        break;
                    case "3":
                        /*VeggiePizza veggiePizza*/ pizza = new VeggiePizza(crustType, crustCost, size, sizeCost);
                        //APizza pizza = veggiePizza;
                        done = true;
                        break;
                    case "4":
                        /*CustomPizza customPizza*/ pizza = new CustomPizza(crustType, crustCost, size, sizeCost);
                        
                        //APizza pizza = customPizza;
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
        //!Not done, might not need
        public static Customer ReadCustomerFromXML(string name)
        {
            Address address = new Address();
            Customer customer = new Customer(name, address);
            //get customer from XML who's name matches
            return customer;
        }
        public static void InvalidInput()
        {
            Console.WriteLine("Not a valid input");
        }
    }
}
