using System;

namespace Core
{
	/// <summary>
	/// Basic fee where charges are based only on consumption.
	/// </summary>
	public class FixedConsumptionFee : IFee
	{
		/// <summary>
		/// Price is cost per per consumption unit
		/// </summary>
		/// <value>Base price</value>
		public decimal Price { get; set;}

		public FixedConsumptionFee (decimal pricePerUnit)
		{
			Price = pricePerUnit;
		}

		public decimal Calculate(Consumption c)
		{
			return c.ConsumptionUnits * Price;
		}
	}
}

