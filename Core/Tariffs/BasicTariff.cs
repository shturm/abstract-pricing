using System;

namespace Core
{
	/// <summary>
	/// Tariff expressing a fixed monthly fee + fixed consumption fee
	/// </summary>
	public class BasicTariff : Tariff
	{
		public BasicTariff (string name, decimal monthlyPrice, decimal pricePerUnit) : base(name)
		{
			var monthlyFee = new ReoccuringFixedPriceFee (monthlyPrice, Occurences.Monthly);
			var consumptionFee = new FixedConsumptionFee (pricePerUnit);

			Fees.Add (monthlyFee);
			Fees.Add (consumptionFee);
		}
	}
}

