// Copyright (c) MOSA Project. Licensed under the New BSD License.

using syntSharp.Apps;

namespace syntSharp;

public static class AppManager
{
	public static readonly IApp[] Applications =
	{
		new Clear(),
		new Credits(),
		new Help(),
        new Ver(),
	};

	public static bool Execute(string name)
	{
		foreach (var app in Applications)
		{
			if (app.Name.ToLower() == name.ToLower())
			{
				app.Execute();
				return true;
			}
		}

		return false;
	}
}