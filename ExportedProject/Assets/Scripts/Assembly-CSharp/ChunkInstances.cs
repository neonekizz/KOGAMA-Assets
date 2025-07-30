using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MV.WorldObject;
using UnityEngine;

public class ChunkInstances : IEnumerator, IEnumerable
{
	public struct ChunkInstanceVariables
	{
		public Guid guid;

		public GameObject gameObject;

		public BoxCollider collider;

		public MeshRenderer renderer;

		public MeshFilter filter;

		public bool transparent;
	}

	private readonly Dictionary<IntVector, ChunkInstanceVariables> chunkInstances;

	public int Count => 0;

	public object Current => null;

	public event EventHandler<ChunkInstancesChanged> Changed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Add(object sender, IntVector intVector, ChunkInstanceVariables chunkInstanceVariables)
	{
	}

	public void SetTransparent(bool t)
	{
	}

	public void Remove(IntVector intVector)
	{
	}

	public bool Contains(IntVector intVector)
	{
		return false;
	}

	public bool TryGetValue(IntVector intVector, out ChunkInstanceVariables gameObject)
	{
		gameObject = default(ChunkInstanceVariables);
		return false;
	}

	public ChunkInstanceVariables GetChunk(IntVector intVector)
	{
		return default(ChunkInstanceVariables);
	}

	public void Clear()
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Reset()
	{
	}

	public string Guids()
	{
		return null;
	}
}
