using System;
// Name: Immanuella Busari
// SID: 191 525 9
// Edited: 10/05/2020


namespace DrinksMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Simple program for vending machines.
             */
            Drinks drinks = new Drinks();
            Machine vendingMachine = new Machine();
            bool exitProgram = false;
            int userInput;
            

            do
            {
                Console.WriteLine("\n\nPlease select your drink: \n" +
                "1) Tea.   2) Tea + sugar   3) Tea + milk   4) Tea + sugar + milk \n" +
                "5) Coffee.   6) Coffee + sugar   7) Coffee + milk   8) Coffee + sugar + milk \n" +
                "9) Quit");
                
                //  Handle user input
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //  perform the relevant action
                switch(userInput)
                {
                    case 1:
                        drinks.AddTea(ref vendingMachine);
                        break;
                    case 2:
                        drinks.AddTeaS(ref vendingMachine);
                        break;
                    case 3:
                        drinks.AddTeaM(ref vendingMachine);
                        break;
                    case 4:
                        drinks.AddTeaSM(ref vendingMachine);
                        break;
                    case 5:
                        drinks.AddCoffee(ref vendingMachine);
                        break;
                    case 6:
                        drinks.AddCoffeeS(ref vendingMachine);
                        break;
                    case 7:
                        drinks.AddCoffeeM(ref vendingMachine);
                        break;
                    case 8:
                        drinks.AddCoffeeSM(ref vendingMachine);
                        break;
                    case 9:
                        Console.WriteLine("Bye, bye");
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("This input doesn't exist...");
                        break;
                }

            } while (!exitProgram);

        }
    }
}
