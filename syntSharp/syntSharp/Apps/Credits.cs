using System;

namespace syntSharp.Apps;

public class Credits : IApp
{
	public string Name => "cred";

	public string Description => "Shows everyone who contributed to the project.";

	public void Execute()
	{
		Console.WriteLine("---- synt# Credits ----");
		Console.WriteLine(" FowluhhDevBCFunny\n");
	}
}