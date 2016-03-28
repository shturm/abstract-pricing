using System;
using NUnit.Framework;


namespace Core.Tests
{
	[TestFixture]
	public class PackagedTariffTest
	{
		[Test]
		[TestCase(800, 0.30, 4000, 3500, 800)]
		[TestCase(800, 0.30, 4000, 4500, 950)]
		[TestCase(800, 0.30, 4000, 6000, 1400)]
		[Category ("Integration")]
		public void CalculatesAnnualCosts (decimal annualPrice, decimal pricePerUnit, decimal consumptionThreshold, decimal unitsPerYear, decimal expectedCost)
		{
			var cut = new PackagedTariff ("Product B", annualPrice, pricePerUnit, consumptionThreshold);
			var c = new Consumption (unitsPerYear);

			var actualCost = cut.Calculate (c);
			Assert.AreEqual (expectedCost, actualCost);
		}
	}
}

