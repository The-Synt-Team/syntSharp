// Copyright (c) MOSA Project. Licensed under the New BSD License.

using System;
using Mosa.Kernel.BareMetal;
using Mosa.Runtime.Plug;

namespace syntSharp;

public static class Program
{
	public static string version = "1.0";
	public static string user = "";

	[Plug("Mosa.Runtime.StartUp::BootOptions")]
	public static void SetBootOptions()
	{
		BootSettings.EnableDebugOutput = true;
		//BootSettings.EnableVirtualMemory = true;
		//BootSettings.EnableMinimalBoot = true;
	}

	public static void EntryPoint()
	{
		Debug.WriteLine("Program::EntryPoint()");

		Console.ResetColor();
		Console.Clear();
		Console.WriteLine("synt# v" + version);
		Console.WriteLine("Type 'help' for commands.\n");

		Login();
	}

	static void Login() {
		Console.Write("Username: ");
		user = Console.ReadLine();
		Commands();
	}

	static void Commands() {
		while (true)
		{
			Console.Write(user + "@synt >> ");

			var cmd = Console.ReadLine();

			if (cmd == "quit")
				break;

			if (!AppManager.Execute(cmd))
			{
				Console.WriteLine("Unknown command: " + cmd);
			}
		}
	}
}
