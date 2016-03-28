using System;
using NUnit.Framework;

namespace Core.Tests
{
	[TestFixture]
	public class BasicTariffTest
	{
		[Test]
		[TestCase(5, 0.22, 3500, 830)]
		[TestCase(5, 0.22, 4500, 1050)]
		[TestCase(5, 0.22, 6000, 1380)]
		[Category ("Integration")]
		public void CalculatesAnnualCosts(decimal monthlyFee, decimal pricePerUnit, decimal unitsPerYear, decimal expectedCost)
		{
			var cut = new BasicTariff ("Product A", monthlyFee, pricePerUnit);
			var c = new Consumption (unitsPerYear);

			var actualCost = cut.Calculate (c);

			Assert.AreEqual (expectedCost, actualCost);
		}
	}
}

