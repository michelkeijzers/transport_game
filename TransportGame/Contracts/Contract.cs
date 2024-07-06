class Contract
{
	public Contract()
	{
		Name = string.Empty;
		Income = 0;
		SetRandomProduct();
		Months = _random.Next(1, 7);
		AssignedTruck = null;
	}

	private void SetRandomProduct()
	{
		var products = new Dictionary<string, int>
		{
			{ "Tomatoes", 10000 },
			{ "Books", 20000 },
			{ "Computers", 60000 },
		};

		int randomIndex = _random.Next(products.Count);
		var randomProduct = products.ElementAt(randomIndex);
		Name = randomProduct.Key;
		Income = randomProduct.Value;
	}

	public string Name { get; set;  }

	public int Months { get; set; }

	public int Income { get; set; }

	public Truck? AssignedTruck { get; set; }

	private Random _random = new Random();

}