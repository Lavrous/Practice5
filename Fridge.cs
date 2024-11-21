using System;

namespace practice5
{
	public class Fridge : HomeAppliance
	{
		private int temp;

		public Fridge() : this("N/A", 1, -1)
		{ }
		public Fridge(string brand, int price, int temp) : base(brand, price)
		{
			Temp = temp;
		}

		public int Temp
		{
			get => temp;
			set
			{
				ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 5, "Temp");
				temp = value;
			}
		}
		
		public override void Print()
		{
			Console.WriteLine($"Brand: {Brand}, price: {Price}, temp: {Temp}");
		}
		public override string ToString()
		{
			return $"Brand: {Brand}, price: {Price}, temp: {Temp}";
		}
	}
}
