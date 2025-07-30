using UnityEngine;
using UnityEngine.UI;

public class ChatControllerUGUI : ChatControllerBase
{
	[SerializeField]
	private RectTransform inputAreaDeactivated;

	[SerializeField]
	private InputField inputField;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Color killMessageColor;

	[SerializeField]
	private VerticalLayoutGroup textGroup;

	private bool waitForLocalPlayerReady;

	private bool shouldUpdateFade;

	private float startTime;

	private const float TimeBeforeFade = 10f;

	private const float FadeTime = 1f;

	private float currFade;

	private bool currentlyInLobbyState;

	protected override void DoAwake()
	{
	}

	protected override void DoStart()
	{
	}

	public void SubscribeToMessages()
	{
	}

	private void WarnForSpam()
	{
	}

	public void Initialize()
	{
	}

	private void InitializeReady()
	{
	}

	protected override void UpdateLockedState()
	{
	}

	private void Update()
	{
	}

	private void ChatHotkeyPressed()
	{
	}

	public void ChatFocusChanged(bool enterChatMode)
	{
	}

	public void UpdateFadeTime()
	{
	}

	private void ScrollbarChanged(Vector2 value)
	{
	}

	public void OnLobbyStateChange(bool cursorLocked)
	{
	}

	protected override void AddLine(string text)
	{
	}

	private void OnEnable()
	{
	}
}
