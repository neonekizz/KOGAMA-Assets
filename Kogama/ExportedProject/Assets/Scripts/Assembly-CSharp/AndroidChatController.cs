using UnityEngine;

public class AndroidChatController : ChatControllerBase
{
	[SerializeField]
	private ChatConsoleModes chatConsoleModes;

	[SerializeField]
	private RectTransform rectTransform;

	[SerializeField]
	private RectTransform expandChat;

	[SerializeField]
	private RectTransform minimizeChat;

	public void Initialize()
	{
	}

	public void OnChatModeTapped()
	{
	}

	public void OnLobbyStateChange(bool inLobbyState)
	{
	}

	private void SetMode(ChatConsoleMode chatConsoleMode)
	{
	}
}
