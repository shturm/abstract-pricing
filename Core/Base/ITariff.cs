using System;
using System.Collections.Generic;

namespace Core
{
	/// <summary>
	/// Describes minimal structure and behavior of a Tariff.
	/// </summary>
	public interface ITariff
	{
		String Name {get; set;}
		List<IFee> Fees { get; set;}
		decimal Calculate (Consumption c);
	}
}

