namespace AsciiGames
{
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
			Console.WriteLine($"Owned Trucks:");
			if (TruckCollection.Count == 0)
			{
				Console.WriteLine(" None");
			}
			else
			{
				Console.WriteLine("Truck ID    ------------------------ Assigned Contract ---------------------");
				Console.WriteLine("            Product               Income (EUR)   Remaining Duration (months)");
				Console.WriteLine("--------    -----------------     -------------- ---------------------------");
				foreach (Truck truck in TruckCollection)
				{
					Console.WriteLine($"    {truck.Id:N2}        {AssignedContractAsText(truck)} ");
				}
			}
		}

		public string AssignedContractAsText(Truck truck)
		{
			string text;
			Contract? contract = truck.Contract;
			if (contract == null)
			{
				text = "  -";
			}
			else
			{
				text = $"{contract.Name, -20} {contract.Income,10:N0}          {contract.Months,2:N0}";
			}
			return text;
		}

		public List<Truck> TruckCollection { get; set; }
	}
}