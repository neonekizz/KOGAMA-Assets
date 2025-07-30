using UnityEngine;

public abstract class PlayModeControlsBase : MonoBehaviour
{
	[SerializeField]
	private CrossHairAndroid crossHair;

	[SerializeField]
	private GameObject crossHairGO;

	[SerializeField]
	protected ShowUse useButtonLarge;

	[SerializeField]
	private JoystickControllerStack joystickControllerStack;

	private PickupGUIFlags showingEquipableUI;

	private WaitForTicks waitForMs;

	private bool testForLowFPS;

	private bool waitedUntilPlaying;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void ShowEUseIcon(ShowUseOption option)
	{
	}

	public void HideEUseIcon()
	{
	}

	public IGUICrossHair GetCrossHair()
	{
		return null;
	}

	protected virtual void SetUseButtonVisible(bool visible, ShowUseOption? option = null)
	{
	}
}
