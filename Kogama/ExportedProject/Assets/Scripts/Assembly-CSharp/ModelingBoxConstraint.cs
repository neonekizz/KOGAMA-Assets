using System;
using System.Runtime.CompilerServices;
using MV.WorldObject;
using UnityEngine;

public class ModelingBoxConstraint : IModelingConstraint
{
	private ObscuredIntVector minCorner;

	private ObscuredIntVector maxCorner;

	private Vector3 center;

	public ObscuredIntVector MinCorner
	{
		get
		{
			return default(ObscuredIntVector);
		}
		protected set
		{
		}
	}

	public ObscuredIntVector MaxCorner
	{
		get
		{
			return default(ObscuredIntVector);
		}
		protected set
		{
		}
	}

	public Vector3 FMinCorner { get; private set; }

	public Vector3 FMaxCorner { get; private set; }

	public Vector3 Center
	{
		get
		{
			return default(Vector3);
		}
		protected set
		{
		}
	}

	public event EventHandler<ConstraintBoxChangedEventArgs> BoxChanged
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

	public ModelingBoxConstraint(IntVector size)
	{
	}

	public ModelingBoxConstraint(IntVector minCorner, IntVector maxCorner)
	{
	}

	protected void ChangeBox(IntVector minCorner, IntVector maxCorner)
	{
	}

	protected virtual void OnBoxChanged(ConstraintBoxChangedEventArgs args)
	{
	}

	public virtual bool CanAddCubeAt(IntVector pos)
	{
		return false;
	}

	public virtual bool CanRemoveCubeAt(IntVector pos)
	{
		return false;
	}

	public virtual bool CanEditCubeAt(IntVector pos)
	{
		return false;
	}
}
