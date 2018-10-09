namespace VendingMachine
{
  .
  .
  .
  
  public void DepositCoin(int money)
  {
  .
  .
  .
  
  }
  
  public bool checkTotal()
  {
      if (RunningTotal >= costOfDrink)
          return true;
      else
          return false;
  }
  
  public void DisplayDrinkSelection()
  {
  Console.WriteLine("Write down all items in vending machine");
  Console.WriteLine("Please, make your selection");
  MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
  }
  
  privte void MakeDrinkSelection(char selection)
  {
     bool selected = false
     while (!selected)
     {
        switch(selection)
        {
          case 'C':
              Console.WriteLine("Thank you for choosing a Coke");
              ReturnCharge();
              selected = true;
              break
          case 'P':
              Console.WriteLine("Thank you for choosing a Pepsi");
              ReturnCharge();
              selected = true;
              break
          case 'D':
              Console.WriteLine("Thank you for choosing a DietCoke");
              ReturnCharge();
              selected = true;
              break
          default:
              Console.WriteLine("Invalid Selection. Please re-enter your selection: ");             
              selection = Convert.ToChar(Console.ReadLine().ToUpper());
              selected = false;
              break;
             
        }
     }
  }
  
  Private void ReturnCharge()
  {
      if (RunningTotal > costOfDrink)
          Console.WriteLine("Your charge is {0:C}", (RunningTotal - costOfDrink) * 0.01);
  }
}
