// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace syntSharp;

public interface IApp
{
	string Name { get; }

	string Description { get; }

	void Execute();
}