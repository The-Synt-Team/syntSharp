using System;

namespace syntSharp.Apps;

public class Clear : IApp
{
	public string Name => "cls";

	public string Description => "Clears the screen.";

	public void Execute()
	{
		Console.Clear();
	}
}