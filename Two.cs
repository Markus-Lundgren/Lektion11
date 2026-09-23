// class Program
// {
// 	static void Main()
// 	{
// 		BankAccount konto = new BankAccount(1000);

// 		Console.Write("Hur mycket vill du ta ut? ");
// 		int amount = int.Parse(Console.ReadLine());

// 		try { konto.Withdraw(amount); }
// 		catch (InvalidOperationException)
// 		{
// 			Console.WriteLine("Du kan inte ta ut så mycket pengar!");
// 		}
// 		finally { Console.WriteLine($"Ditt saldo är nu: {konto.Balance}"); }

// 		Console.Write("Hur mycket vill du sätta in? ");
// 		int deposit = 0;
// 		try { deposit = int.Parse(Console.ReadLine()); }
// 		catch (FormatException) { Console.WriteLine("Du måste skriva ett heltal!"); }

// 		try { konto.Deposit(deposit); }
// 		catch (InvalidOperationException) { Console.WriteLine("Du kan inte sätta in mindre än 0"); }
// 		catch (OverflowException) { Console.WriteLine("Du kan inte sätta in så mycket pengar"); }
// 		finally { Console.WriteLine($"Ditt saldo är nu: {konto.Balance}"); }
// 	}
// }

// class BankAccount
// {
// 	public int Balance { get; private set; }

// 	public BankAccount(int saldo)
// 	{
// 		Balance = saldo;
// 	}

// 	public void Withdraw(int amount)
// 	{
// 		if (Balance - amount < 0) throw new InvalidOperationException("Du har inte tillräckligt med pengar");
// 		else Balance -= amount;
// 	}

// 	public void Deposit(int amount)
// 	{
// 		if (amount < 0) throw new InvalidOperationException("Du kan inte sätta in negativ med pengar");
// 		else if (amount > int.MaxValue) throw new OverflowException("Du kan inte sätta in sp mycket pengar. Overflow");
// 		else Balance += amount;
// 	}
// }
