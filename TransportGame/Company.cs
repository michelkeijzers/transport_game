namespace AsciiGames
{
	public class Company
	{
		public Company()
		{
			Name = "";
			Cash = 0;
			Trucks = new Trucks();
		}

		public void Init()
		{
			Cash = 1000000;
		}

		public bool IsBroke()
		{
			return Cash < 0;
		}

		public void ChangeCompanyName()
		{
			Console.Write("Enter new company name: ");
			try
			{
				Name = Console.ReadLine() ?? "<NoName>";
				if (Name == String.Empty)
				{
					Name = "<NoName>";
				}
			}
			catch (IOException)
			{
				// Ignore
			}
			Print();
		}

		public void BuyTruck()
		{
			Cash -= 100000;
			Trucks.AddTruck();
			Print();
			Trucks.Print();
		}

		public void SellTruck()
		{
			if (Trucks.TruckCollection.Count == 0)
			{
				Console.WriteLine("You do not have any trucks.");
			}
			else
			{
				Trucks.Print();
				Console.Write("Enter ID of truck to sell: ");
				string id = String.Empty;
				try
				{
					id = Console.ReadLine() ?? String.Empty;
				}
				catch (IOException)
				{
					// Ignore
				}

				Truck? truckToSell = Trucks.GetById(id);
				if (truckToSell == null)
				{
					Console.WriteLine($"You do not own a truck with ID {id}.");
				}
				else
				{
					Cash += 90000;
					Trucks.RemoveTruck(truckToSell);
					Print();
				}
			}
		}

		public void Print()
		{
			Console.WriteLine("==================== COMPANY INFO ====================");
			Console.WriteLine($"Company name: {Name}, cash: EUR {Cash:N0}");
		}

		public string Name { get; set; }

		public double Cash { get; set; }

		public Trucks Trucks { get; set; }
	};
}