public class UserCommandSelector
{
	public enum ECommand
	{
		None,
		ChangeCompanyName,
		CompanyInfo,
		TruckList,
		BuyTruck,
		SellTruck,
		EndMonth,
		Quit
	};

	public enum EMenu
	{
		Main,
		Trucks
	};

	public UserCommandSelector()
	{
		MenuPrinter = new MenuPrinter();
		Command = ECommand.None;
	}

	public ECommand Select()
	{
		do
		{
			MenuPrinter.PrintCommands(Menu);
			_menuChanged = false;
			SelectCommand();
		} while (_menuChanged);

		return Command;
	}

	private void SelectCommand()
	{
		Console.Write("Select command: ");
		ConsoleKeyInfo input = Console.ReadKey();
		Console.WriteLine("");

		switch (Menu)
		{
			case EMenu.Main:
				ProcessMainMenu(input);
				break;

			case EMenu.Trucks:
				ProcessTruckMenu(input);
				break;
		}
	}

	private void ProcessMainMenu(ConsoleKeyInfo input)
	{
		switch (input.Key)
		{
			case ConsoleKey.C:
				Command = ECommand.CompanyInfo;
				break;

			case ConsoleKey.E:
				Command = ECommand.EndMonth;
				break;

			case ConsoleKey.N:
				Command = ECommand.ChangeCompanyName;
				break;

			case ConsoleKey.Q:
				Command = ECommand.Quit;
				break;

			case ConsoleKey.T:
				Menu = EMenu.Trucks;
				break;
		}
	}

	private void ProcessTruckMenu(ConsoleKeyInfo input)
	{
		switch (input.Key)
		{
			case ConsoleKey.B:
				Command = ECommand.BuyTruck;
				break;

			case ConsoleKey.L:
				Command = ECommand.TruckList;
				break;

			case ConsoleKey.S:
				Command = ECommand.SellTruck;
				break;

			case ConsoleKey.Enter:
				Menu = EMenu.Main;
				break;
		}
	}

	private MenuPrinter MenuPrinter;

	private EMenu _menu;
	private bool _menuChanged;

	private EMenu Menu
	{
		get { return _menu; }
		set { _menu = value; _menuChanged = true; }
	}

	public ECommand Command { get; set; }
}
