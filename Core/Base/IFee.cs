using System;

namespace Core
{
	/// <summary>
	/// Describes minimal behavior and structure of a fee
	/// </summary>
	public interface IFee
	{
		/// <summary>
		/// Price is used to calculate the total cost of the fee. Differente fees calculate it differently.
		/// </summary>
		/// <value>Base price</value>
		decimal Price {get;set;}

		/// <summary>
		/// Calculate the total cost of the fee in the context of the specified consumption.
		/// </summary>
		/// <param name="consumption">Consumption.</param>
		decimal Calculate(Consumption consumption);
	}
}

