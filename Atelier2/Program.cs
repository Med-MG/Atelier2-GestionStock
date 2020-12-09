using System;

namespace Atelier2
{
    class Program
    {
        private static byte quiteProgram = 0;
        static void Main(string[] args)
        {
            //Article article = new Article(1212, "LOca", 123, 1111);
            //Console.WriteLine($"ref:{article._NumberRef}");

            RunProgram();



        }

        public static void RunProgram()
        {
           
                //Instantiate Stock class, In order to use it's Methods
                Stock stock = new Stock();
                InputManager msges = new InputManager();

                while (quiteProgram == 0)
                {
                    

                    //Display a menu to the user and take the Inpute
                    msges.ManageStockMessage();

                    //Choice Manager Method
                    msges.Choice(msges.InputChoice);

                    Console.WriteLine("Press Q to (quite) or (Enter) to continue");
                    if (Console.ReadKey().Key == ConsoleKey.Q)
                    {
                        quiteProgram = 1;
                    }
                    else
                    {
                        quiteProgram = 0;
                    }
                }

           

            
        }
    }
}
