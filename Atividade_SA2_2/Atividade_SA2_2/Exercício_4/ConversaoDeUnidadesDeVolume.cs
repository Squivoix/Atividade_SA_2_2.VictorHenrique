namespace Exercício_4
{
	/// <summary>Classe que converte unidades.</summary>
	public static class ConversaoDeUnidadesDeVolume
	{
		/// <summary>Recebe um valor em Litros e converte para Centímetros Cúbicos.</summary>
		public static float CentimetrosCubicos(float valor)
		{
			return valor * 1000;
		}

		/// <summary>Recebe um valor em Metros Cúbicos e converte para Litros.</summary>
		public static float Litros(float valor)
		{
			return valor * 1000;
		}

		/// <summary>Recebe um valor em Metros Cúbicos e converte para Pés Cúbicos.</summary>
		public static float PesCubicos(float valor)
		{
			return valor * 35.32f;
		}

		/// <summary>Recebe um valor em Galão Americano e converte para Pelogadas Cúbicas.</summary>
		public static float PolegadasCubicas(float valor)
		{
			return valor * 231;
		}

		/// <summary>Recebe um valor em Galão Americano e converte para Litros.</summary>
		public static double Litros(double valor)
		{
			return valor * 231;
		}

	}

}
