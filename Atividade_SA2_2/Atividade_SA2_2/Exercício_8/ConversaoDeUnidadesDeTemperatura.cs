
namespace Exercício_8
{
	public static class ConversaoDeUnidadesDeTemperatura
	{
		/*
		Celsius
		Fahrenheit
		Kelvin
		Réamur
		Rankine
		*/

		#region Celsius
		public static float CelsiusParaFahrenheit(float C)
		{
			return (9 * C / 5) + 32;
		}

		public static float CelsiusParaKelvin(float C)
		{
			return C + 273.15f;
		}
		
		public static float CelsiusParaReamur(float C)
		{
			return C * 4 / 5;
		}

		public static float CelsiusParaRankine(float C)
		{
			return KelvinParaRankine(CelsiusParaKelvin(C));
		}
		#endregion

		#region Fahrenheit
		public static float FahrenheitParaCelsius(float F)
		{
			return (F - 32) * 5 / 9;
		}

		public static float FahrenheitParaKelvin(float F)
		{
			return CelsiusParaKelvin(FahrenheitParaCelsius(F));
		}

		public static float FahrenheitParaReamur(float F)
		{
			return CelsiusParaReamur(FahrenheitParaCelsius(F));
		}

		public static float FahrenheitParaRankine(float F)
		{
			return KelvinParaRankine(FahrenheitParaKelvin(F));
		}
		#endregion

		#region Kelvin
		public static float KelvinParaCelsius(float K)
		{
			return K - 273.15f;
		}

		public static float KelvinParaFahrenheit(float K)
		{
			return CelsiusParaFahrenheit(KelvinParaCelsius(K));
		}

		public static float KelvinParaReamur(float K)
		{
			return CelsiusParaReamur(KelvinParaCelsius(K));
		}

		public static float KelvinParaRankine(float K)
		{
			return K * 1.8f;
		}
		#endregion

		#region Réamur
		public static float ReamurParaCelsius(float Re)
		{
			return Re * 5 / 4;
		}

		public static float ReamurParaFahrenheit(float Re)
		{
			return CelsiusParaFahrenheit(ReamurParaCelsius(Re));
		}

		public static float ReamurParaKelvin(float Re)
		{
			return CelsiusParaKelvin(ReamurParaCelsius(Re));
		}

		public static float ReamurParaRankine(float Re)
		{
			return KelvinParaRankine(ReamurParaKelvin(Re));
		}
		#endregion

		#region Rankine
		public static float RankineParaCelsius(float Ra)
		{
			return KelvinParaCelsius(RankineParaKelvin(Ra));
		}

		public static float RankineParaFahrenheit(float Ra)
		{
			return CelsiusParaFahrenheit(RankineParaCelsius(Ra));
		}

		public static float RankineParaKelvin(float Ra)
		{
			return Ra / 1.8f;
		}

		public static float RankineParaReamur(float Ra)
		{
			return CelsiusParaReamur(RankineParaCelsius(Ra));
		}
		#endregion


	}
}
