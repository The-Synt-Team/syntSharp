using System;

namespace syntSharp.Apps;

public class Help : IApp
{
	public string Name => "help";

	public string Description => "Shows information about all commands.";

	public void Execute()
	{
		foreach (var app in AppManager.Applications)
			Console.WriteLine(app.Name + " - " + app.Description);
        Console.Write("\n");
	}
}