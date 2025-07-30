using MV.WorldObject;
using UnityEngine;

public class WorldEditorDrawPlane : MonoBehaviour
{
	public delegate void AltitudeChangedDelegate(int altitude);

	private const float CUBE_OFFSET = 0.5f;

	private const int MeshScale = 100;

	private Camera mainCamera;

	public AltitudeChangedDelegate OnAltitudeChanged;

	public GameObject DrawPlaneVisualization;

	public GameObject DrawPlaneCursor;

	private GameObject _targetGameObject;

	private bool isActive;

	private int _altitude;

	private DrawPlaneAxis drawPlaneAxis;

	private float lastMovePlaneDelta;

	private Plane editorPlane;

	private Vector3 _cachedPos;

	public GameObject TargetGameObject
	{
		set
		{
		}
	}

	public bool IsOnLandscape => false;

	public Vector3 Pos
	{
		get
		{
			return default(Vector3);
		}
		private set
		{
		}
	}

	public bool Active
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int Altitude
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

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

	public void CachePos()
	{
	}

	public void ReturnDrawPlaneToLandscape()
	{
	}

	public void RestorePos()
	{
	}

	public void Awake()
	{
	}

	private void GenerateDrawPlane(GameObject drawPlane)
	{
	}

	private void GenerateMesh(Mesh mesh, bool scale = true)
	{
	}

	private void SetLayer(int layer)
	{
	}

	public void SetToCameraPos()
	{
	}

	public void SetToGridAlignedPos(Vector3 pos)
	{
	}

	public void SetToTargetGameObjectZero()
	{
	}

	private void UpdateEditorPlanePosition()
	{
	}

	public bool GetCubePosOnDrawplane(GameObject gameObject, out IntVector intVectorHitPos)
	{
		intVectorHitPos = default(IntVector);
		return false;
	}

	private void UpdateAltitude()
	{
	}

	private void Update()
	{
	}

	private void FollowAvatar()
	{
	}

	private Vector3 GetDirectionVector()
	{
		return default(Vector3);
	}

	public void MoveDrawPlane(int dir)
	{
	}

	public void SetDrawPlaneHeight(float height)
	{
	}

	public bool Pick(ref Vector3 hit)
	{
		return false;
	}

	private bool RayCast(Ray ray, ref Vector3 hit, bool ignoreActiveFlag)
	{
		return false;
	}

	private Vector3 GetCubePlaceOffset()
	{
		return default(Vector3);
	}

	private Vector3 GetOffsetVector()
	{
		return default(Vector3);
	}
}
