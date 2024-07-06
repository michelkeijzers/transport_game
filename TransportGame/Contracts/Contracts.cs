using System.Xml.Linq;

namespace AsciiGames
{
	public class Contracts
	{
		public Contracts()
		{
			ContractsList = new List<Contract>();
		}

		public void Init()
		{
			Renew(3);
		}

		public void Renew(int amount)
		{
			Remove(amount);
			Add(amount);
		}

		/// <summary>
		/// Remove first <amount> unused.
		/// </summary>
		/// <param name="amount"></param>
		public void Remove(int amount)
		{
			foreach (var contract in ContractsList.ToList())
			{
				if (contract.AssignedTruck == null)
				{
					ContractsList.Remove(contract);
					amount--;
					if (amount == 0)
					{
						break;
					}
				}
			}
		}

		public void Add(int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				ContractsList.Add(new Contract());
			}
		}

		public void Print()
		{
			Console.WriteLine("Contracts");
			Console.WriteLine("Name                  Income (EUR) Duration (Months) Assigned Truck");
			Console.WriteLine("--------------------- ------------ ----------------- --------------");
			foreach (var contract in ContractsList)
			{
				Console.WriteLine($"{contract.Name, -20} {contract.Income,10:N0}            {contract.Months,2:N0}            " + 
					$"{ (contract.AssignedTruck == null ? "-" : contract.AssignedTruck.Id) }");
			}
		}

		private readonly List<Contract> ContractsList;
	}
}