using UnityEngine;

public class ProtectedTransform
{
	private readonly Transform transform;

	public Vector3 localPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion localRotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Quaternion rotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector3 localScale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public ProtectedTransform(Transform transform)
	{
	}
}
