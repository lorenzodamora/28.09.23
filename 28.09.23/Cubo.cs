using System;
using static System.Console;

namespace _28_09_23.Geometria
{
	class Cubo : Quadrato
	{
		//volume = area * altezza

		public Cubo() : base()
		{
			WriteLine("Cubo: Costruttore senza parametri");
			//lato = 0.0f;
		}

		public Cubo(float lato_) : base(lato_)
		{
			WriteLine("Cubo: Costruttore");
			//if(!SetLato(lato_)) lato = 0.0f;
		}

		public float GetSuperficie()
		{
			WriteLine("Cubo: GetSuperficie");
			return GetPerimetro()*6;
		}

		public float GetVolume()
		{
			WriteLine("Cubo: GetVolume");
			return GetArea()*GetLato();
		}

	}
}
