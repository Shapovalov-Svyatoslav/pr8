using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
	public class FoodProduct : Product, IConsumable
	{
		public FoodProduct(string name, int price, DateTime expiryDate) : base(name, price)
		{
			this.expiryDate = expiryDate;
		}

        public DateTime expiryDate { get; set; }

		public void Consume()
		{
            Console.WriteLine($"Product {name} is consumed");
        }
	}
}
