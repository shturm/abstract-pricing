using NUnit.Framework;
using System;
using Moq;
using System.Collections.Generic;

namespace Core.Tests
{
	[TestFixture ()]
	public class TariffTest
	{
		[Test]
		[Category ("Unit")]
		public void Calculate_SumsFees()
		{
			// arrange
			var fee1 = new Mock<IFee> ();
			var fee2 = new Mock<IFee> ();
			fee1.Setup (f => f.Calculate (It.IsAny<Consumption> ())).Returns (1);
			fee2.Setup (f => f.Calculate (It.IsAny<Consumption> ())).Returns (1);
			var cut = new TariffMock () {
				Fees =  new List<IFee>() {fee1.Object, fee2.Object}
			};
			var consumptionStub = new Consumption (42);

			// act
			var actual = cut.Calculate (consumptionStub);

			// assert
			Assert.AreEqual (2, actual);
		}
	}

	class TariffMock : Tariff { 
		public TariffMock () : base("mock")
		{
			
		}
	}

}

