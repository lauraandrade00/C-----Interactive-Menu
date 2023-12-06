string option;
bool displayMenu = true;

while(displayMenu) 
{
  Console.WriteLine("Type your option:");
  Console.WriteLine("1 - Register customer");
  Console.WriteLine("2 - Search for customer");
  Console.WriteLine("3 - Delete customer");
  Console.WriteLine("4 - Close program");

  option = Console.ReadLine();

  switch(option) {
    case "1":
      Console.WriteLine("Customer register");
      break;
    case "2":
      Console.WriteLine("Customer search");
      break;
    case "3":
      Console.WriteLine("Customer deleted.");
      break;
    case "4":
      Console.WriteLine("Closing...");
      displayMenu = false;
      //Enviroment.Exit(0);
      break;
    
    default:
      Console.WriteLine("Invalid option");
      break;
  }
}

Console.WriteLine("Program ended");