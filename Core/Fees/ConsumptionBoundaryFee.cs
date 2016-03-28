using System;

namespace Core
{

	/// <summary>
	/// Fee where charges are only applied when consumption is in certain boundaries.
	/// </summary>
	public class ConsumptionBoundaryFee : IFee
	{
		public decimal Price { get; set;}

		/// <summary>
		/// Charges are only applied when consumption is above the LowerConsumptionBoundary
		/// </summary>
		public decimal LowerConsumptionBoundary; 
		/// <summary>
		/// Charges are only applied when consumption is below the UpperConsumptionBoundary 
		/// </summary>
		public decimal UpperConsumptionBoundary;

		public ConsumptionBoundaryFee (decimal price, decimal lower, decimal upper)
		{
			Price = price;
			LowerConsumptionBoundary = lower;
			UpperConsumptionBoundary = upper;
		}

		public decimal Calculate(Consumption c) 
		{
			if (c.ConsumptionUnits > LowerConsumptionBoundary && c.ConsumptionUnits < UpperConsumptionBoundary) {
				return Price * (c.ConsumptionUnits - LowerConsumptionBoundary);
			}

			return 0;
		}
	}
}