using MV.WorldObject;
using UnityEngine;

public class DrawPlaneControllerUUI : MonoBehaviour
{
	private bool inputEnabled;

	[SerializeField]
	protected WorldEditorDrawPlane worldEditorDrawPlane;

	public bool IsDrawPlaneActive => false;

	public bool InputEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int Altitude => 0;

	public DrawPlaneAxis Orientation
	{
		get
		{
			return default(DrawPlaneAxis);
		}
		set
		{
		}
	}

	public Vector3 Pos => default(Vector3);

	public void Initialize()
	{
	}

	public bool Pick(ref Vector3 hit)
	{
		return false;
	}

	public void DrawPlaneToModel(GameObject gameObject)
	{
	}

	public void ToggleDrawPlane()
	{
	}

	public void HideDrawPlane()
	{
	}

	public void ReturnDrawPlaneToLandscape()
	{
	}

	public bool GetCubePosOnDrawplane(GameObject gameObject, out IntVector intVectorHitPosition)
	{
		intVectorHitPosition = default(IntVector);
		return false;
	}

	public void MoveDrawPlane(int dir)
	{
	}
}
