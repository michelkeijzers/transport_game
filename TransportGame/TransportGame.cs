namespace AsciiGames
{
	public class TransportGame
	{
		public TransportGame()
		{
			Company = new Company();
			Contracts = new Contracts();
			Date = new Date();
			IsQuitCommandRequested = false;

			_userCommandSelector = new();
			_userCommandExecuter = new(this);
		}

		public void Init()
		{
			Company.Init();
			Company.Name = "MK BV";
			Contracts.Init();
			Date.Init();
		}

		public void Play()
		{
			Console.WriteLine("Start");
			Date.Print();
			Company.Print();

			while (!IsGameEnded())
			{
				Command.EId command = _userCommandSelector.Select();
				_userCommandExecuter.Execute(command);
			}

			EndGame();
		}

		public void EndMonth()
		{
			Date.GotoNextMonth();
		}

		private bool IsGameEnded()
		{
			return IsQuitCommandRequested || Company.IsBroke();
		}

		private void EndGame()
		{
			if (IsQuitCommandRequested)
			{
				Console.WriteLine("Game has ended because you quit.");
			}
			else if (Company.IsBroke())
			{
				Console.WriteLine($"Game has ended because you are broke: EUR {Company.Cash:N0}");
			}
		}

		public Company Company { get; set; }

		public Contracts Contracts { get; set; }

		public Date Date { get; set; }

		public bool IsQuitCommandRequested { get; set; }

		private readonly UserCommandSelector _userCommandSelector;
		private readonly UserCommandExecuter _userCommandExecuter;
	}
}