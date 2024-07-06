public class UserCommandExecuter
{
	public UserCommandExecuter(TransportGame transportGame)
	{
		_transportGame = transportGame;
	}

	public void Execute(UserCommandSelector.ECommand command)
	{
		switch (command)
		{
		case UserCommandSelector.ECommand.None:
			break;

		case UserCommandSelector.ECommand.CompanyInfo:
			_transportGame.Company.Print();
			break;

		case UserCommandSelector.ECommand.ChangeCompanyName:
			_transportGame.Company.ChangeCompanyName();
			break;

		case UserCommandSelector.ECommand.TruckList:
			_transportGame.Company.Trucks.Print();
			break;

		case UserCommandSelector.ECommand.BuyTruck:
			_transportGame.Company.BuyTruck();
			break;

		case UserCommandSelector.ECommand.SellTruck:
			_transportGame.Company.SellTruck();
			break;

		case UserCommandSelector.ECommand.EndMonth:
			_transportGame.EndMonth();
			break;

		case UserCommandSelector.ECommand.Quit:
			_transportGame.IsQuitCommandRequested = true;
			break;

		default:
			Console.WriteLine("INVALID COMMAND");
			break;
		}
	}

	private TransportGame _transportGame;
}