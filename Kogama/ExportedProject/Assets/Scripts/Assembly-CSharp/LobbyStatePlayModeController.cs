using UnityEngine;

public class LobbyStatePlayModeController : MonoBehaviour
{
	public enum LobbyStateMode
	{
		LobbyMenu = 0,
		PauseMenu = 1
	}

	private bool isInLobbyState;

	private bool wantsToEnterPlayState;

	private DesktopInGameGUIController inGameController;

	private RectTransform lobbyState;

	private InGameMenu inGameMenu;

	private ChatControllerUGUI chatController;

	public bool IsInLobbyState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Initialize(DesktopInGameGUIController inGameController, RectTransform lobbyState, InGameMenu inGameMenu, ChatControllerUGUI chatController)
	{
	}

	private void OnCursorLockChanged(bool cursorLocked)
	{
	}

	private void Update()
	{
	}

	private void SetObjectToLobbyState(bool isInLobbyState)
	{
	}

	private void ActivateLobbyState()
	{
	}

	private void DeactivateLobbyState()
	{
	}

	private void EnableLobbyState()
	{
	}

	private void DisableLobbyState()
	{
	}
}
