using System;
using static System.Console;

namespace _28_09_23.Geometria
{
	class Quadrato
	{
		/**
		 * doc comment
		 */
		private float lato;
		public float Lato
		{
			get { return GetLato(); }
			set { SetLato(value); }
		}

		public Quadrato()
		{
			WriteLine("Quadrato: Costruttore senza parametri");
			lato = 0.0f;
		}

		public Quadrato(float lato_)
		{
			WriteLine("Quadrato: Costruttore");
			if(!SetLato(lato_)) lato = 0.0f;
		}

		public bool SetLato(float lato_)
		{
			WriteLine("Quadrato: SetLato");
			if(lato_ <= 0.0f) return false;
			lato = lato_;
			return true;
		}

		public bool SetLato(string lato_stringa)
		{
			WriteLine("Quadrato: SetLato string");
			if(float.TryParse(lato_stringa, out float lato_) || lato_ <= 0.0f)
			{
				lato = lato_;
				return true;
			}
			else
				return false;
		}

		public float GetLato()
		{
			WriteLine("Quadrato: GetLato");
			return lato;
		}

		public float GetPerimetro()
		{
			WriteLine("Quadrato: GetPerimetro");
			return lato*4;
		}

		public float GetArea()
		{
			WriteLine("Quadrato: GetArea");
			return lato*lato;
		}

	}
}
