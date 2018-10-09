


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
                drinkMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }
            
            drinkMachine.DisplayDrinkSelection();
            
            Console.ReadLine();
        }
    
    }

}
