using System;
using MV.WorldObject;

public class CubeModelChangedEventArgs : EventArgs
{
	public readonly CubeAction Action;

	public readonly IntVector Pos;

	public readonly MVCubeModelBase Sender;

	public CubeModelChangedEventArgs(CubeAction action, IntVector pos, MVCubeModelBase sender)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
