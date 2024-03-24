// Copyright (c) MOSA Project. Licensed under the New BSD License.

using System;

namespace syntSharp.Apps;

public class Ver : IApp
{
	public string Name => "ver";

	public string Description => "Prints the version.";

	public void Execute()
	{
		Console.WriteLine("v" + Program.version + "\n");
	}
}