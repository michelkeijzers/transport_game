namespace AsciiGames
{
	public class Truck
	{
		public Truck()
		{
			Id = LatestId.ToString();
			LatestId++;
		}

		public void Print()
		{
			Console.WriteLine($"Truck {Id}");
		}

		public string Id { get; set; }

		public Contract? Contract { get; set; }

		static int LatestId = 1;
	}
}