using UnityEngine;
using UnityEngine.UI;

public class DesktopCubeModelingToolsController : MonoBehaviour
{
	[SerializeField]
	private Button defaultTool;

	[Header("Buttons")]
	[SerializeField]
	protected Button editCube;

	[SerializeField]
	protected Button deletecube;

	[SerializeField]
	protected Button paintCube;

	[SerializeField]
	protected Button pickCubeColor;

	[Header("Settings")]
	[SerializeField]
	private float disabledAlpha;

	[SerializeField]
	private float enabledAlpha;

	private CubeModelingStateMachine cubeModelingStateMachine;

	public CubeModelingEvent ActiveTool { get; private set; }

	private void Awake()
	{
	}

	public CubeModelingStateMachine.HoverType CurrentlyHovered()
	{
		return default(CubeModelingStateMachine.HoverType);
	}

	public virtual void SetupButtons()
	{
	}

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine)
	{
	}

	private void Start()
	{
	}

	protected void SetToolActive(CubeModelingEvent cubeTool)
	{
	}

	private void SetButtonTransparency(CubeModelingEvent cubeTool)
	{
	}

	public void Select(CubeModelingEvent tool)
	{
	}

	public void SetAllToTransparent()
	{
	}

	private void SetAlpha(Image image, float alpha)
	{
	}

	public void SwitchToDefaultTool()
	{
	}
}
