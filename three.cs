class Program
{
	static List<User> users = [
		new(){ Username = "alice" },
		new(){ Username = "bob" },
		new(){ Username = "charlie" }
	];

	static void Main()
	{
		Console.Write("Ange användarnamn att hitta: ");
		string username = Console.ReadLine();

		try
		{
			User user = FindUser(username);
			Console.WriteLine($"Hittade användaren: {user.Username} med ID {user.Id}");
		}
		catch (KeyNotFoundException)
		{
			Console.WriteLine("Användaren finns inte");
		}

	}

	static User FindUser(string username)
	{
		User us = users.Find(u => u.Username == username);
		if (us == null) throw new KeyNotFoundException("Hittade inte användaren"); // Implementera sökningen här
		else return us;
	}
}

class User
{
	public int Id { get; set; } = Random.Shared.Next(1, 100);
	public string Username { get; set; }
}
