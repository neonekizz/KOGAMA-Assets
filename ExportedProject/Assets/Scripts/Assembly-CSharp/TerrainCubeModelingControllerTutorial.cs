using UnityEngine;
using UnityEngine.UI;

public class TerrainCubeModelingControllerTutorial : MonoBehaviour
{
	[SerializeField]
	private RawImage materialsButtonImage;

	[SerializeField]
	private DesktopCubeModelingToolsController desktopCubeModelingController;

	private MaterialsController materialsController;

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine, MaterialsController materialsController)
	{
	}

	private void SetMaterial(byte materialId)
	{
	}

	private void OnDestroy()
	{
	}
}
