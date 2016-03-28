using System;

namespace Core
{
	/// <summary>
	/// A fee where charges are applied one or multiple times during the reporting period
	/// </summary>
	public class ReoccuringFixedPriceFee : IFee
	{
		public Occurences Occurence;

		/// <summary>
		/// Price to be applied as many times as the period is contained in the reporting period
		/// </summary>
		/// <value>Base price</value>
		public decimal Price {get;set;}

		public ReoccuringFixedPriceFee (decimal price, Occurences occurence)
		{
			Price = price;
			Occurence = occurence;
		}

		public decimal Calculate(Consumption c) {
			if (Occurence == Occurences.Monthly) {
				return Price * 12;
			}

			return Price;
		}
	}
}

