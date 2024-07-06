public class Trucks
{
	public Trucks()
	{
		TruckCollection = new List<Truck>();
	}

	public Truck? GetById(string id)
	{
		return TruckCollection.FirstOrDefault(t => t.Id == id);
	}

	public void AddTruck()
	{
		TruckCollection.Add(new Truck());
	}

	public void RemoveTruck(Truck truck)
	{
		TruckCollection.Remove(truck);
	}

	public void Print()
	{
		Console.Write($" Owned Trucks:");
		if (TruckCollection.Count == 0)
		{
			Console.WriteLine("  None");
		}
		else
		{
			Console.WriteLine("");
			foreach (Truck truck in TruckCollection)
			{
				Console.Write("  ");
				truck.Print();
			}
		}
	}

	public List<Truck> TruckCollection { get; set; }
}