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

	static int LatestId = 0;
}