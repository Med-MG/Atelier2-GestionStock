using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
    class Stock
    {

        //Declaring a list, and  Initializing it with some values
        List<Article> Stck = new List<Article>() { new Article(001, "Keyboard", 350, 599), new Article(002, "Mouse", 100, 225) };




        public void AddProduct(Article article)
        {
            Stck.Add(article);
            DisplayAll();
            Console.WriteLine($"The follow product had been added successfully : \r\n" +
                $"Reference number: {article._NumberRef} \r\n" +
                $"Name: {article._Name}\r\n" +
                $"Prix Achat: {article._PrixAchat}\r\n" +
                $"Prix Vente: {article._PrixVente}");
            Console.WriteLine("\r\n______________________________________\r\n");

            
        }

        public void DisplayAll()
        {
            foreach (var item in Stck)
            {
                Console.WriteLine($"Refrence: {item._NumberRef} \r\n Name: {item._Name} \r\n Prix Achat: {item._PrixAchat} \r\n Prix Vente: {item._PrixVente}");
                Console.WriteLine("\r\n______________________________________\r\n");

            }
        }

        public void DisplayOne(String name)
        {
            var product = Stck.FindAll(x => x._Name.Contains(name));
            
            if (product.Count == 0)
            {
                Console.WriteLine("Sorry we couldn't find what you're looking for");
            }
            else
            {
                foreach (var item in product)
                {
                    Console.WriteLine("Here is the item you're looking for :");
                    Console.WriteLine($"Refrence: {item._NumberRef} \r\n Name: {item._Name} \r\n Prix Achat: {item._PrixAchat} \r\n Prix Vente: {item._PrixVente}");
                    Console.WriteLine("\r\n______________________________________\r\n");
                }
            }
            
        }

        public void DisplayPricy(decimal price)
        {
            var product = Stck.FindAll(x => x._PrixVente > price);
            if (product.Count == 0)
            {
                Console.WriteLine("Sorry we couldn't find a product that is greater than {0}", price);
            }
            else
            {
                foreach (var item in product)
                {
                    Console.WriteLine("Here is the item you're looking for :");
                    Console.WriteLine($"Refrence: {item._NumberRef} \r\n Name: {item._Name} \r\n Prix Achat: {item._PrixAchat} \r\n Prix Vente: {item._PrixVente}");
                    Console.WriteLine("\r\n______________________________________\r\n");
                }
            }
        }
        //Delete an Item using it's name
        public void DeleteItem(String Name)
        {
            //Code for deleting using name
            int Index = Stck.FindIndex(x => x._Name.Contains(Name));
            Stck.RemoveAt(Index);
            Console.WriteLine($"The Item with the name {Name} Has been deleted \r\n This is your Enventory after the item has been deleted : \r\n");
            DisplayAll();
        }
        //Delete an Item using it's reference
        public void DeleteItem(int Reference)
        {
            //Code for deleting using reference
        }

        //Update an Item 
        public void UpdateItem(int reference, Article article)
        {
            int Index = Stck.FindIndex(x => x._NumberRef == reference);
            Stck[Index] = article;
            DisplayAll();

        }
    }
}
