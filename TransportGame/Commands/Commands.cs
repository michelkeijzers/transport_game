using static AsciiGames.Command;

namespace AsciiGames
{
	public class Commands
	{
		public Commands()
		{
			CommandList = new List<Command>
			{
				// Main menu
				new(Command.EId.GoToCompanyMenu, Command.EMenu.Main, ConsoleKey.C, "C", "Go to Company Menu", Command.EMenu.Company),
				new(Command.EId.GoToMarketMenu, Command.EMenu.Main, ConsoleKey.M, "M", "Go to Market Menu", Command.EMenu.Market),
				new(Command.EId.StayInMainMenu, Command.EMenu.Main, ConsoleKey.Enter, "Enter", "Main Menu", Command.EMenu.Main),

				// Market Menu
				new(Command.EId.ShowContracts, Command.EMenu.Market, ConsoleKey.S, "S", "Show Contracts"),
				new(Command.EId.ReturnFromMarketMenu, Command.EMenu.Market, ConsoleKey.Enter, "Enter", "Main Menu", Command.EMenu.Main),

				// Company Menu
				new(Command.EId.ShowCompanyInfo, Command.EMenu.Company, ConsoleKey.S, "S", "Show Company Info"),
				new(Command.EId.EditCompanyName, Command.EMenu.Company, ConsoleKey.E, "E", "Edit Company Name"),
				new(Command.EId.GoToCompanyMenu, Command.EMenu.Company, ConsoleKey.T, "T", "Go to Trucks Menu", Command.EMenu.Trucks),
				new(Command.EId.ReturnFromCompanyMenu, Command.EMenu.Company, ConsoleKey.Enter, "Enter", "Main Menu", Command.EMenu.Main),

				// Trucks Menu
				new(Command.EId.ShowTruckList, Command.EMenu.Trucks, ConsoleKey.S, "S", "Show Truck List"),
				new(Command.EId.BuyTruck, Command.EMenu.Trucks, ConsoleKey.B, "B", "Buy Truck"),
				new(Command.EId.SellTruck, Command.EMenu.Trucks, ConsoleKey.S, "S", "Sell Truck"),
				new(Command.EId.ReturnFromTrucksMenu, Command.EMenu.Trucks, ConsoleKey.Enter, "Enter", "Main Menu", Command.EMenu.Company),

				new(Command.EId.QuitGame, Command.EMenu.Main, ConsoleKey.Q, "Q", "Quit Game"),
			};
		}
		

		public Command? GetByKeyInMenu(ConsoleKey key, EMenu menu)
		{
			return CommandList.FirstOrDefault(c => c.Key == key && c.Menu == menu);
			
      }

		public List<Command> CommandList { get; set; }
	}
}