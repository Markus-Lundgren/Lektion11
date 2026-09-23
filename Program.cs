namespace Lektion11;

class Program
{
	static void Main()
	{
		//Exercise1(); // Hoppa över övning 1
		Exercise2();
		//Exercise3();
	}

	static void Exercise1()
	{
		// kod för övning 1
		int tal;

		while (true)
		{
			try
			{
				Console.Write("Skriv in ett heltal: ");
				string input = Console.ReadLine();
				tal = int.Parse(input);

				break;
			}
			catch (OverflowException)
			{

				Console.WriteLine("Detta nummer var för stort eller för litet");
			}
			catch (System.FormatException)
			{
				Console.WriteLine("Detta var inte en int");
			}
		}

		Console.WriteLine($"Du skrev in talet: {tal}");
	}

	static void Exercise2()
	{
		// kod för övning 2
		while (true)
		{
			int tal1 = 0;
			int tal2 = 0;
			int resultat = 0;
			try
			{
				Console.Write("Skriv in ett heltal: ");
				tal1 = int.Parse(Console.ReadLine());
			}
			catch (OverflowException)
			{

				Console.WriteLine("Detta nummer var för stort eller för litet");
				continue;
			}
			catch (System.FormatException)
			{
				Console.WriteLine("Detta var inte en int");
				continue;
			}

			try
			{
				Console.Write("Skriv in ett heltal till: ");
				tal2 = int.Parse(Console.ReadLine());
			}

			catch (OverflowException)
			{
				Console.WriteLine("Detta nummer var för stort eller för litet");
				continue;
			}
			catch (System.FormatException)
			{
				Console.WriteLine("Detta var inte en int");
				continue;
			}

			try { resultat = tal1 / tal2; }
			catch (DivideByZeroException)
			{
				Console.WriteLine("Du kan inte dela med noll");
				continue;
			}
			catch (OverflowException)
			{
				Console.WriteLine("Detta nummer var för stort eller för litet");
				continue;
			}
			catch (System.FormatException)
			{
				Console.WriteLine("Detta var inte en int");
				continue;
			}
			Console.WriteLine($"Resultatet blev: {resultat}");
		}
	}

	static void Exercise3()
	{
		// kod för övning 3
		Console.Write("Ange filnamn: ");
		string filnamn = Console.ReadLine();

		string innehåll = File.ReadAllText(filnamn);
		Console.WriteLine("Filens innehåll:");
		Console.WriteLine(innehåll);
	}

}
