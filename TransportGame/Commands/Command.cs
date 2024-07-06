namespace AsciiGames
{
	public class Command
	{
		public enum EId
		{
			None,

			// Main Menu
			MainMenu,
			GoToMarketMenu,
			GoToCompanyMenu,
			StayInMainMenu,
			EndMonth,
			QuitGame,

			//  Market Menu
			ShowContracts,
			ReturnFromMarketMenu,

			//  Company Menu
			ShowCompanyInfo,
			EditCompanyName,
			GoToTrucksMenu,
			ReturnFromCompanyMenu,
			
			// Company / Trucks Menu
			ShowTruckList,
			BuyTruck,
			SellTruck,
			ReturnFromTrucksMenu
		};

		public enum EMenu
		{
			None,
			Main,
			Market,
			Company,
			Trucks
		};

		public Command(EId id, EMenu menu, ConsoleKey key, string keyString, string text, EMenu toMenu = EMenu.None)
		{
			Id = id;
			Menu = menu;
			Key = key;
			KeyString = keyString;
			Text = text;
			ToMenu = toMenu;
		}

		public static string GetMenuName(EMenu menu)
		{
			string name = String.Empty;
			switch (menu)
			{
				case EMenu.Main: name = "Main Menu "; break;
				case EMenu.Company: name = "Company Menu "; break;
				case EMenu.Trucks: name = "Trucks Menu "; break;
				case EMenu.Market: name = "Market Menu"; break;
				default: Console.WriteLine($"ERROR: INVALID menu {menu}"); break;
			}
			return name;
		}

		public EId Id { get; set; }

		public EMenu Menu { get; set; }

		public ConsoleKey Key { get; set; }

		public string KeyString { get; set; }

		public string Text { get; set; }

		public EMenu ToMenu { get; set; }

	}
}