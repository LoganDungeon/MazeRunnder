using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World
{

	// Dimensions of the world
	public int Width // X direction
	{
		get;
		protected set;
	}

	public int Height // Z direction
	{
		get;
		protected set;
	}

	private Tile[,] tiles;

	public World(int width, int height)
	{
		this.Width = width;
		this.Height = height;

		this.tiles = new Tile[width, height];

		for(int x = 0; x < width; x++)
		{
			for(int z = 0; z < height; z++)
			{
				this.tiles[x, z] = new Tile(x, z);
			}
		}
	}

	public Tile GetTileAt(int x, int z)
	{
		return tiles[x, z];
	}

	public Tile GetTileAt(float x, float z)
	{
		return tiles[Mathf.FloorToInt(x), Mathf.FloorToInt(z)];
	}
}
