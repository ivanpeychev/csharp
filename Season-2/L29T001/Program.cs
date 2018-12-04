using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
	static void Main()
	{
		bool hasSession = false;

		if(!File.Exists("users.txt"))
		{
			File.Create("users.txt");
		}

		while (true)
		{
			Console.WriteLine("Enter command:");
			string command = Console.ReadLine().Trim();
			Console.WriteLine();

			if (command == "end")
				break;

			else if (command == "register")
			{
				hasSession = Register();
			}

			else if (command == "list")
			{
				ListUsers();
			}

			else if (command == "login")
			{
				hasSession = Login();
			}

			else if (command == "logout")
			{
				if (hasSession)
				{
					hasSession = false;
					Console.WriteLine("You successfully logged out.");
				}
				else
				{
					Console.WriteLine("You are not logged in.");
				}
			}
			Console.WriteLine();
		}
	}

	public static bool Register()
	{
		bool regSuccess = false;

		while (true)
		{
			Console.WriteLine("Enter username:");
			string username = Console.ReadLine().Trim();

			if (UserExists(username))
			{
				Console.WriteLine("Username taken!");
				continue;
			}

			string password = string.Empty;
			string passConfirm = string.Empty;

			do
			{
				Console.WriteLine("Enter password:");
				password = Console.ReadLine().Trim();
				Console.WriteLine("Confirm password:");
				passConfirm = Console.ReadLine().Trim();
			} while (passConfirm != password);

			File.AppendAllText("users.txt", string.Format($"{username} {password}\n"));

			regSuccess = true;
			break;
		}

		return regSuccess;
	}

	public static bool Login()
	{
		Console.WriteLine("Enter username:");
		string username = Console.ReadLine().Trim();

		if (UserExists(username))
		{
			string originalPassword = GetPassword(username);
			string password = string.Empty;
			int failCount = 0;

			do
			{
				Console.WriteLine($"Enter password ({3 - failCount} tries remaining):");
				password = Console.ReadLine().Trim();
				if (password != originalPassword)
					failCount++;

				if (failCount >= 3)
				{
					Console.WriteLine("You are banned!");
					return false;
				}

			} while (password != originalPassword);

			Console.WriteLine("Login successful!");
			return true;
		}
		else
		{
			Console.WriteLine("No such user exists!");
			return false;
		}
	}

	public static bool UserExists(string username)
	{
		return GetUsers().Any(i => i.IndexOf(username) > -1) ? true : false;
	}

	public static List<string> GetUsers()
	{
		return File.ReadAllLines("users.txt").ToList();
	}

	public static void ListUsers()
	{
		GetUsers().ForEach(u => Console.WriteLine(u));
	}

	public static string GetPassword(string username)
	{
		var users = GetUsers();
		string password = string.Empty;

		foreach (var user in users)
		{
			if (user.IndexOf(username) > -1)
			{
				var userPasswordPair = user.Split(' ').ToList();
				password = userPasswordPair[1];
				break;
			}
		}

		return password;
	}

}