using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl4
{
	public class Car
	{
		public string BrandName { get; set; }
		public string BoxType { get; set; }
		public string FuelType { get; set; }
		public string Color { get; set; }
		public decimal Price { get; set; }
		public Car(string nameB, string lasboxP, string fuelP, string colorP, decimal priceP)
		{
			BrandName = nameB;
			BoxType = lasboxP;
			FuelType = fuelP;
			Color = colorP;
			Price = priceP;
		}
		public override string ToString()
		{
			return $"Prica car: {Price}";
		}
	}

	public class Comp<T> : IComparer<T> where T : Car
	{
		public int Compare(T car1, T car2)
		{
			Car c1 = (Car)car1;
			Car c2 = (Car)car2;
			if (c1.Price > c2.Price)
				return 1;
			if (c1.Price < c2.Price)
				return -1;
			else
				return 0;
		}
	}


}
