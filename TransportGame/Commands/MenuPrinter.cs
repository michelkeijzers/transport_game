public class MenuPrinter
{
	public MenuPrinter()
	{
	}

	public void PrintCommands(UserCommandSelector.EMenu menu)
	{
		switch (menu)
		{
			case UserCommandSelector.EMenu.Main:
				PrintMainMenu();
				break;

			case UserCommandSelector.EMenu.Trucks:
				PrintTrucksMenu();
				break;
		}
	}

private void PrintMainMenu()
	{
		Console.WriteLine();
		Console.WriteLine("Main Menu");
		Console.WriteLine("c: Company Info    n: Change Company Name    t: Trucks*    e:End Month    q: Quit");
	}

	private static void PrintTrucksMenu()
	{
		Console.WriteLine();
		Console.WriteLine("Trucks Menu");
		Console.WriteLine("l: List    b: Buy Truck    s: Sell Truck    enter: Main Menu");
	}

}