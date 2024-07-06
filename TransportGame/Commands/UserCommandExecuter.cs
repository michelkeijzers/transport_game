namespace AsciiGames
{
	public class UserCommandExecuter
	{
		public UserCommandExecuter(TransportGame transportGame)
		{
			_transportGame = transportGame;
		}

		public void Execute(Command.EId command)
		{
			switch (command)
			{
				case Command.EId.None:break;

				// Main Menu
				case Command.EId.EndMonth: _transportGame.EndMonth(); break;
				case Command.EId.QuitGame: _transportGame.IsQuitCommandRequested = true; break;

				// Market Menu
				case Command.EId.ShowContracts: _transportGame.Contracts.Print(); break;

				// Company Menu
				case Command.EId.ShowCompanyInfo: _transportGame.Company.Print(); break;
				case Command.EId.EditCompanyName: _transportGame.Company.ChangeCompanyName(); break;

				// Company / Trucks Menu
				case Command.EId.ShowTruckList: _transportGame.Company.Trucks.Print(); break;
				case Command.EId.BuyTruck: _transportGame.Company.BuyTruck(); break;
				case Command.EId.SellTruck: _transportGame.Company.SellTruck(); break;
				default: Console.WriteLine("INVALID COMMAND"); break;
			}
		}

		private readonly TransportGame _transportGame;
	}
}