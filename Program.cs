using System;

namespace TestingClass
{
	public class Ssak
	{
		private string imie;
		private int wiek;

		public Ssak(){}
		public Ssak(string imie, int wiek)
		{
			this.imie = imie;
			this.wiek = wiek;
		}

		public void info()
		{
			Console.WriteLine( "Wiek: " + wiek + " | Imie: " + imie);
		}
	}


	class MainClass
	{
		public static void Main (string[] args)
		{
			Ssak ssak = new Ssak ("Azor", 5);
			ssak.info ();
		}
	}
}
