using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class Tile
{
	// Coordinates of the tile
	public int X
	{
		get;
		protected set;
	}

	public int Z
	{
		get;
		protected set;
	}

	public Tile(int x, int z)
	{
		this.X = x;
		this.Z = z;
	}
}
