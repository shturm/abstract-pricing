using System;
using System.Collections.Generic;
using Core;

namespace Execution
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Abstract Pricing Model Demo:");
			Console.WriteLine ("");
			Console.WriteLine ("Type numbers for kWh\\year. Hit [Enter] to exit.");

			var productA = new BasicTariff("Basic Electricity Tariff", 5, 0.22m);
			var productB = new PackagedTariff ("Packaged Electricity Tariff", 800, 0.3m, 4000);

			string tmp;
			do {
				Console.Write ("kWh\\year: ");
				tmp = Console.ReadLine ();
				if (!String.IsNullOrEmpty(tmp)) {
					var dTmp = Convert.ToDecimal (tmp);
					PrintTariff(productA, dTmp);
					PrintTariff(productB, dTmp);
					Console.WriteLine ();
				}
			} while (!String.IsNullOrEmpty (tmp));
				
		}

		static void PrintTariff(Tariff tariff, decimal consumptionUnits) 
		{
			var result = tariff.Calculate (new Consumption (consumptionUnits));
			Console.WriteLine ("Tariff name: {0} Annual costs: {1}", tariff.Name, result);
		}
	}
}
