using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ModeControllerBase : MonoBehaviour, IToggleFps, IEventSystemHandler, ITogglePlayerIndicators, IPlayModeUI
{
	[SerializeField]
	private GameObject fpsCounterPrefab;

	[SerializeField]
	private LocationIndicatorsManager locationIndicatorsManagerPrefab;

	[SerializeField]
	private Sprite resetGameSprite;

	private GameObject fpsCounter;

	private LocationIndicatorsManager locationIndicatorsManager;

	public virtual bool IsInPauseMenu
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDying { get; set; }

	public bool IsInLobby { get; set; }

	public virtual void Initialize()
	{
	}

	public virtual void ShowEUseIcon(ShowUseOption option, int woId = 0)
	{
	}

	public virtual void HideEUseIcon()
	{
	}

	public virtual IGUICrossHair GetCrossHair()
	{
		return null;
	}

	protected bool CannotLeaveEditPlayMode()
	{
		return false;
	}

	public void ToggleFps()
	{
	}

	public void TogglePlayerIndicators()
	{
	}

	protected void HandleFpsShortcut()
	{
	}
}
