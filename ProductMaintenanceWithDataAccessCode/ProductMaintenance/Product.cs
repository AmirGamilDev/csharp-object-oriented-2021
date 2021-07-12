using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Product
	{
        public Product() { }

		public Product(string code, string description, decimal price)
		{
			this.Code = code;
			this.Description = description;
			this.Price = price;
		}

        public string Code { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string GetDisplayText() => Code + ", " + Price.ToString("c") + ", " + Description;

		public string GetDisplayText(string sep) => Code + sep + Price.ToString("c") + sep + Description;
	}
}
