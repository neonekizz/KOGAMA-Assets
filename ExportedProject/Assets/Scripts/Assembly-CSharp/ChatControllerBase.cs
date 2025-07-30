using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public abstract class ChatControllerBase : MonoBehaviour
{
	[SerializeField]
	private Text consoleLinePrefab;

	[SerializeField]
	private Color systemMessageColor;

	[SerializeField]
	private Color warningColor;

	[SerializeField]
	private Color chatMessageColor;

	[SerializeField]
	private Color chatMessageDefaultNameColor;

	[SerializeField]
	protected Color sayColor;

	[SerializeField]
	private Color friendNameColor;

	private readonly Queue<Text> lines;

	private const int MaxLineCount = 50;

	private bool promptRegisterForChat;

	protected bool chatLocked;

	private const bool HideChat = true;

	[field: SerializeField]
	public RectTransform ContentPanel { get; private set; }

	[field: SerializeField]
	public ScrollRect ScrollRect { get; private set; }

	[field: SerializeField]
	public RectTransform InputAreaRoot { get; private set; }

	[field: SerializeField]
	public ConsoleDragAndTapHandler EnterChatButton { get; private set; }

	[field: SerializeField]
	public SendMessageControl MessageController { get; private set; }

	private void Awake()
	{
	}

	protected virtual void DoAwake()
	{
	}

	private void Start()
	{
	}

	protected virtual void DoStart()
	{
	}

	protected virtual void UpdateLockedState()
	{
	}

	protected virtual void AddLine(string text)
	{
	}

	private Text ReuseLine()
	{
		return null;
	}

	private Text InstantiateNewLine()
	{
		return null;
	}

	protected void ReceiveMessage(MVGameMsgType msgType, Dictionary<object, object> message)
	{
	}

	private void AddAdminMessage(Dictionary<object, object> data)
	{
	}

	private void AddWarningMessage(Dictionary<object, object> data)
	{
	}

	private void HandleTeamChatMessage(Dictionary<object, object> data)
	{
	}

	private string FormatSayChatMessage(Dictionary<object, object> data)
	{
		return null;
	}

	private void AddChatLine(Dictionary<object, object> data)
	{
	}

	private string FormatTeamChatMessage(Dictionary<object, object> data)
	{
		return null;
	}

	private void HandleSayChatMessage(Dictionary<object, object> data)
	{
	}

	protected void OnSayChatMessageHeard(Dictionary<object, object> data)
	{
	}

	private void OnDestroy()
	{
	}

	protected void PromptRegisterForChatIfApplicable()
	{
	}
}
