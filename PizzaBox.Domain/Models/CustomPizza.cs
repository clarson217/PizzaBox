using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.IO;
using System;

namespace PizzaBox.Domain.Models
{
    public class CustomPizza : APizza
    {
        // protected override void AddCrust(string crustType, double cost)
        // {
        //     crust = new Crust(crustType, cost);
        // }
        // protected override void AddSize(string size, double cost)
        // {
        //     this.size = new Size(size, cost);
        // }
        protected void AddToppings()
        {
            bool done = false;
            string input;
            do
            {
                Console.WriteLine("Would you like to add a topping? \n($.50 per topping, duplicates will count as additional servings)\n 1. Yes\n 2. No");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        
                        Console.WriteLine("What topping would you like to add?\n 1. Pepperonni" +
                                        "\n 2. Sausage\n 3. Bacon\n 4. Ham\n 5. Onions" +
                                        "\n 6. Olives\n 7. Banana Peppers\n 8. Tomatoes" +
                                        "\n 9. Spinach");
                        input = Console.ReadLine();
                        switch(input)
                        {
                            case "1":
                                Topping pepperonni = new Topping("Pepperonni", 0.50);
                                Toppings.Add(pepperonni);
                                break;
                            case "2":
                                Topping sausage = new Topping("Sausage", 0.50);
                                Toppings.Add(sausage);
                                break;
                            case "3":
                                Topping bacon = new Topping("Bacon", 0.50);
                                Toppings.Add(bacon);
                                break;
                            case "4":
                                Topping ham = new Topping("Ham", 0.50);
                                Toppings.Add(ham);
                                break;
                            case "5":
                                Topping onions = new Topping("Onions", 0.50);
                                Toppings.Add(onions);
                                break;
                            case "6":
                                Topping olives = new Topping("Olives", 0.50);
                                Toppings.Add(olives);
                                break;
                            case "7":
                                Topping bananaPeppers = new Topping("Banana Peppers", 0.50);
                                Toppings.Add(bananaPeppers);
                                break;
                            case "8":
                                Topping tomatoes = new Topping("Tomatoes", 0.50);
                                Toppings.Add(tomatoes);
                                break;
                            case "9":
                                Topping spinach = new Topping("Spinach", 0.50);
                                Toppings.Add(spinach);
                                break;
                            default:
                                InvalidInput();
                                break;
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine("O.K.");
                        done = true;
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            }while(!done);
        }
        public CustomPizza(string crustType, double crustCost, string size, double sizeCost)
        {
            
            AddCrust(crustType, crustCost);
            AddSize(size, sizeCost);
            AddToppings();
            CalculatePizzaCost();
            ThisName = "Custom Pizza";
            
        }
        public CustomPizza()
        {
            AddCrust("Regular", 0.0);
            AddSize("small", 0.0);
            ThisName = "Custom Pizza";
        }
        
        private void InvalidInput()
        {
            Console.WriteLine("Not a valid input");
        }
    }
}