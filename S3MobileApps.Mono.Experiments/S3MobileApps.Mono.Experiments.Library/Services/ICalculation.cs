using System;

namespace S3MobileApps.Mono.Experiments.Library
{
	public interface ICalculation
	{
		double TipAmount(double subTotal, int generosity);
	}
}

