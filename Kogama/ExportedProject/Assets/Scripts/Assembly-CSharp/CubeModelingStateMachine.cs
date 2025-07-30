using CodeStage.AntiCheat.ObscuredTypes;
using MV.WorldObject;
using UnityEngine;

public class CubeModelingStateMachine : FSMEntity
{
	public delegate void OnCurrentMaterialChangeDelegate(byte currentMaterialId, Material currentMaterial);

	public enum HoverType
	{
		Corner = 0,
		Edge = 1,
		Face = 2,
		None = 3
	}

	public bool useLasers;

	public OnCurrentMaterialChangeDelegate OnCurrentMaterialChange;

	private ObscuredByte currentMaterialId;

	private IModelingConstraint constraint;

	private GameObject gameObject;

	private Camera mainCamera;

	public CubePickingInfo SelectedCube { get; set; }

	public MVCubeModelBase TargetCubeModel { get; private set; }

	public Vector3[] CubeCorners => null;

	public byte[] ByteCubeCorners => null;

	public Material CurrentMaterial => null;

	public byte CurrentMaterialId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool CursorVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public CubeModelingStateMachine(GameObject gameObject)
	{
	}

	public void StartEdit(MVCubeModelBase targetCubeModel, IModelingConstraint constraint = null)
	{
	}

	public void SetConstraint(IModelingConstraint constraint)
	{
	}

	public void EndEdit()
	{
	}

	public override void Update()
	{
	}

	public HoverType CurrentlyHovered()
	{
		return default(HoverType);
	}

	public CubePickingInfo DoPicking()
	{
		return null;
	}

	public void RemoveCursors()
	{
	}

	public void HandleAudio(IntVector pos, AudioActions action)
	{
	}

	public EditCubeChange AddCube()
	{
		return default(EditCubeChange);
	}

	public CanPerformCubeActionResult CanAddCubeAt(IntVector requestedCubePos, CubePickingInfo requestedCube)
	{
		return default(CanPerformCubeActionResult);
	}

	public CanPerformCubeActionResult CanAddCubeAt(IntVector requestedCubePos)
	{
		return default(CanPerformCubeActionResult);
	}

	public CanPerformCubeActionResult CanRemoveCubeAt(CubePickingInfo requestedCube)
	{
		return default(CanPerformCubeActionResult);
	}

	public bool CanEditCubeAt(IntVector requestedCubePos)
	{
		return false;
	}

	public CanPerformCubeActionResult CanReplaceCube(CubePickingInfo requestedCube, byte materialId)
	{
		return default(CanPerformCubeActionResult);
	}
}
