using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinkMachine = new DrinkMachine();

            while (!drinkMachine.checkTotal())
            {
                Console.WriteLine("Please enter coin or bill (5, 10, 20, 100)");
                drinkMachine.depositCoin(Convert.ToInt32(Console.ReadLine()));
            }

            drinkMachine.DisplayDrinkSelection();

            Console.ReadLine();
        }
    }

    class DrinkMachine
    {
        const int costOfDrink = 150;
        public int runningTotal { get; set; }

        public DrinkMachine()
        {
            runningTotal = 0;
        }

        public void depositCoin(int money)
        {
            //machine only takes 5, 10, 20, 50, 100

            switch (money)
            {
                case (5):
                    runningTotal += 5;
                    break;
                case (10):
                    runningTotal += 10;
                    break;
                case (20):
                    runningTotal += 20;
                    break;
                case (50):
                    runningTotal += 50;
                    break;
                case (100):
                    runningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Error: Invalid entry / Niedozwolony nominał. Valid nominals / Przyjmowanie nominały to : 5, 10, 20, 50, 100");
                    break;

            }
        }

        public bool checkTotal()
        {
            if (runningTotal >= costOfDrink)
                return true;
            else
                return false;
        }

        public void DisplayDrinkSelection()
        {
            Console.WriteLine(" *****************");
            Console.WriteLine("* C - Coke *");
            Console.WriteLine("* P - Pepsi *");
            Console.WriteLine("* D - Diet Coke *");
            Console.WriteLine(" *****************");
            Console.WriteLine("Please, make your selection");
            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void MakeDrinkSelection(char selection)
        {
            bool selected = false;

            while (!selected)
            {
                switch (selection)
                {
                    case 'C':
                        Console.WriteLine("Thank you for choosing a Coke");
                        ReturnCharge();
                        selected = true;
                        break;
                    case 'P':
                        Console.WriteLine("Thank you for choosing a Pepsi");
                        ReturnCharge();
                        selected = true;
                        break;
                    case 'D':
                        Console.WriteLine("Thank you for choosing a DietCoke");
                        ReturnCharge();
                        selected = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Please re-enter your selection: ");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selected = false;
                        break;

                }
            }
        }

        private void ReturnCharge()
        {
            int RunningTotal = 0;
            if (runningTotal > costOfDrink)
            {
                //int totalCharge = (RunningTotal - costOfDrink) * 0.01;
                Console.WriteLine("Your charge is " + (RunningTotal - costOfDrink) * 0.01);
            }else if (runningTotal == costOfDrink)
            {
                Console.WriteLine("Nie ma reszty do wydania.");
            }
        }
    }
}
