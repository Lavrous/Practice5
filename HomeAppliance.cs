using System;

namespace practice5
{
	public class HomeAppliance
	{
		protected string brand;
		protected int price;

		public HomeAppliance() : this("N/A", 1)
		{ }
		public HomeAppliance(string brand, int price)
		{
			Brand = brand;
			Price = price;
		}

		public string Brand
		{
			get => brand;
			set => brand = string.IsNullOrEmpty(value) ? throw new ArgumentNullException("Brand") : value;
		}
		public int Price
		{
			get => price;
			set
			{
				ArgumentOutOfRangeException.ThrowIfLessThan(value, 1, "Price");
				price = value;
			}
		}

		public virtual void Print()
		{
			Console.WriteLine($"Brand: {Brand}, price: {Price}");
		}
		public override string ToString()
		{
			return $"Brand: {Brand}, price: {Price}";
		}
	}
}
