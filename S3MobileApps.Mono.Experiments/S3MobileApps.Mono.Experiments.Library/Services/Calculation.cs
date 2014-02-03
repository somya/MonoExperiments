using System;

namespace S3MobileApps.Mono.Experiments.Library
{
	public class Calculation : ICalculation
	{
		public Calculation()
		{
		}


		public double TipAmount( double subTotal, int generosity )
		{
			return subTotal * ((double)generosity)/100.0;
		}

	}
}

