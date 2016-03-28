using System;

namespace Core
{
	public class PackagedTariff : Tariff
	{
		public PackagedTariff (string name, decimal annualPrice, decimal pricePerUnit, decimal consumptionThreshold) : base(name)
		{
			var consumptionFee = new ConsumptionBoundaryFee (pricePerUnit, consumptionThreshold, Decimal.MaxValue);
			var annualFee = new ReoccuringFixedPriceFee (annualPrice, Occurences.Yearly);

			Fees.Add (consumptionFee);
			Fees.Add (annualFee);
		}
	}
}