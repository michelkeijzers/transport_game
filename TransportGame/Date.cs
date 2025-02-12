using System;

namespace AsciiGames
{
	public class Date
	{
		public Date()
		{
			_cultureInfo = new System.Globalization.CultureInfo("en-US");
			DateTime = new DateTime(2024, 1, 1);
		}

		public static void Init()
		{
		}

		public void GotoNextMonth()
		{
			DateTime = DateTime.AddMonths(1);
			Print();
		}

		public void Print()
		{
			string formattedDate = DateTime.ToString("d MMMM yyyy", _cultureInfo);

			Console.WriteLine($"Date: {formattedDate}");
		}

		private DateTime DateTime { get; set; }

		private readonly System.Globalization.CultureInfo _cultureInfo;
	}
}