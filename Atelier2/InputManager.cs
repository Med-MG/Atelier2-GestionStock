using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
    class InputManager
    {
        public int InputChoice { get; set; }

        Stock stock = new Stock();
        public void ManageStockMessage()
        {
            //Console.WriteLine("__ Application Started ");
            Console.WriteLine("Please Choose your next action :"
                + "\r\n 1 -> Ajouter un nouvel Article. "
                + "\r\n 2 -> Afficher tous les Articles du magasin."
                + "\r\n 3 -> Rechercher un Article."
                + "\r\n 4 -> Afficher les Articles dont les prix d’achat est supérieur à une valeur saisie."
                + "\r\n 5 -> Supprimer un Article."
                + "\r\n 6 -> Modifier un Article."
                );
            //Block saperator
            Console.WriteLine("\r\n______________________________________\r\n");

            //Take user Unput
            InputChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public void Choice(int choice)
        {

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your product Reference ? :");
                    int Ref = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your product name ? :");
                    String Name = Console.ReadLine();
                    Console.WriteLine("Your product buying price ? :");
                    decimal BuyPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Your product selling price? :");
                    decimal SellingPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    stock.AddProduct(new Article(Ref, Name, BuyPrice, SellingPrice));
                    break;
                case 2:
                    //Display All Products in The Stock
                    stock.DisplayAll();
                    break;
                case 3:
                    //Find a Certain Product
                    Console.WriteLine("Name of the product you're searching for:");
                    //Search variable, containing the search argument
                    String SearchName = Console.ReadLine();
                    //Calling the method that does the searching
                    stock.DisplayOne(SearchName);
                    break;
                case 4:
                    //Find a Certain Product
                    Console.WriteLine("What price should we base our search on:");
                    //Search variable, containing the search argument
                    decimal Price = Convert.ToInt32(Console.ReadLine());
                    stock.DisplayPricy(Price);
                    break;
                case 5:
                    //Take user unput of the product name
                    Console.WriteLine("The name of the product you want to delete:");
                    //Store the name in a variable
                    String  ProdName = Console.ReadLine();
                    //call on the function to delete the Item
                    stock.DeleteItem(ProdName);
                    
                    break;
                case 6:
                    Console.WriteLine("What is the reference of the product you want to edit:");
                    int PRef = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your product Reference ? :");
                    int ERef = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your product name ? :");
                    String EName = Console.ReadLine();
                    Console.WriteLine("Your product buying price ? :");
                    decimal EBuyPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Your product selling price? :");
                    decimal ESellingPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    stock.UpdateItem(PRef, new Article(ERef, EName, EBuyPrice, ESellingPrice));
                    break;
                default:
                    break;
            }
        }
    }
}
