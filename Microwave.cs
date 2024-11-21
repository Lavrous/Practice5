using System;

namespace practice5
{
	public class Microwave : HomeAppliance
	{
		private int volume;

		public Microwave() : this("N/A", 1, 7)
		{ }
		public Microwave(string brand, int price, int volume) : base(brand, price)
		{
			Volume = volume;
		}

		public int Volume
		{
			get => volume;
			set
			{
				ArgumentOutOfRangeException.ThrowIfLessThan(value, 1, "Volume");
				volume = value;
			}
		}

		public override void Print()
		{
			Console.WriteLine($"Brand: {Brand}, price: {Price}, volume: {Volume}");
		}
		public override string ToString()
		{
			return $"Brand: {Brand}, price: {Price}, volume: {Volume}";
		}
	}
}
