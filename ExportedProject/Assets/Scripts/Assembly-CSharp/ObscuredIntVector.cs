using CodeStage.AntiCheat.ObscuredTypes;
using MV.WorldObject;
using UnityEngine;

public struct ObscuredIntVector
{
	public ObscuredShort x;

	public ObscuredShort y;

	public ObscuredShort z;

	public static readonly ObscuredIntVector One;

	public short this[int key]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ObscuredIntVector iV)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(ObscuredIntVector a, ObscuredIntVector b)
	{
		return false;
	}

	public static bool operator !=(ObscuredIntVector a, ObscuredIntVector b)
	{
		return false;
	}

	public ObscuredIntVector(short x, short y, short z)
	{
		this.x = default(ObscuredShort);
		this.y = default(ObscuredShort);
		this.z = default(ObscuredShort);
	}

	public ObscuredIntVector(int x, int y, int z)
	{
		this.x = default(ObscuredShort);
		this.y = default(ObscuredShort);
		this.z = default(ObscuredShort);
	}

	public ObscuredIntVector(IntVector intVector)
	{
		x = default(ObscuredShort);
		y = default(ObscuredShort);
		z = default(ObscuredShort);
	}

	public ObscuredIntVector(float x, float y, float z)
	{
		this.x = default(ObscuredShort);
		this.y = default(ObscuredShort);
		this.z = default(ObscuredShort);
	}

	public Vector3 ToVector3()
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}

	public static ObscuredIntVector operator +(ObscuredIntVector i1)
	{
		return default(ObscuredIntVector);
	}

	public static ObscuredIntVector operator -(ObscuredIntVector i1)
	{
		return default(ObscuredIntVector);
	}

	public static ObscuredIntVector operator +(ObscuredIntVector i1, ObscuredIntVector i2)
	{
		return default(ObscuredIntVector);
	}

	public static ObscuredIntVector operator -(ObscuredIntVector i1, ObscuredIntVector i2)
	{
		return default(ObscuredIntVector);
	}

	public static ObscuredIntVector operator *(int i, ObscuredIntVector iV)
	{
		return default(ObscuredIntVector);
	}

	public static ObscuredIntVector operator *(ObscuredIntVector iV, int i)
	{
		return default(ObscuredIntVector);
	}

	public static Vector3 operator *(ObscuredIntVector iV, Vector3 vector3)
	{
		return default(Vector3);
	}

	public static ObscuredIntVector operator /(ObscuredIntVector iV, int i)
	{
		return default(ObscuredIntVector);
	}

	public int SquareMagnitude()
	{
		return 0;
	}

	public static int ObscuredIntVectorToIndex(ObscuredIntVector ObscuredIntVector, int chunkSize)
	{
		return 0;
	}

	public static ObscuredIntVector IndexToObscuredIntVector(int index, int chunkSize)
	{
		return default(ObscuredIntVector);
	}
}
