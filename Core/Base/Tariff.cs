using System;
using System.Linq;
using System.Collections.Generic;

namespace Core
{
	/// <summary>
	/// Fascade for a List<IFee>. Contains basic implementation of ITariff. All tariffs must inherit from Tariff.
	/// </summary>
	public abstract class Tariff : ITariff
	{
		public String Name { get; set;}
		public List<IFee> Fees { get; set;}


		public Tariff (string name)
		{
			Name = name;
			Fees = new List<IFee> ();
		}

		/// <summary>
		/// Calculate the sum of all fees in the Tariff
		/// </summary>
		/// <param name="c">Consumption</param>
		public virtual decimal Calculate(Consumption c)
		{
			return Fees.Sum (f => f.Calculate (c));
		}
	}
}