using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DesktopAvatarEditModeController : ModeControllerBase, IActivateUIElement, IEventSystemHandler, IAvatarEditUIState, IEditStateCommands, IAvatarSetBodyGroup, IGetCurrentBody, IAccessoryPopupHandler
{
	private EditorStateMachine editorStateMachine;

	[SerializeField]
	private AvatarEditModeBodyController avatarEditModeBodyController;

	[SerializeField]
	private AvatarSelectionController avatarSelectionController;

	[SerializeField]
	private UIStack uiStack;

	[SerializeField]
	private GameObject stackBottom;

	[SerializeField]
	private AccessoryShopController accessoryShopController;

	[SerializeField]
	private DrawPlaneControllerUUI drawPlaneController;

	[SerializeField]
	private MaterialsController materialsController;

	[SerializeField]
	private AvatarShopController avatarShopController;

	[SerializeField]
	private NotificationsManager notificationsManager;

	[SerializeField]
	private SetupCubeModelTutorialUI setupCubeModelTutorialUI;

	[SerializeField]
	private GoldPurchasedTracker goldPurchasedTracker;

	private int firstTimeActiveAvatar;

	private void Awake()
	{
	}

	private void FirstTimeSetActiveAvatar(int activeAvatarId)
	{
	}

	protected void Update()
	{
	}

	protected void OnDestroy()
	{
	}

	public override void Initialize()
	{
	}

	public void Activate(ActivateUIElement element)
	{
	}

	public void Set(ActiveEditStateUI activeUIElements)
	{
	}

	private void OnPopCubeModelingController()
	{
	}

	public void SetState(EditorEvent editorEvent)
	{
	}

	public void ClearStateStack()
	{
	}

	private void InitializeLocalAvatar()
	{
	}

	public void SelectEditorStateMachineToBodyGroup()
	{
	}

	public void SetBodyGroup(MVBody bodyGroup)
	{
	}

	public void GetCurrentBody(Action<MVBody> callback)
	{
	}

	public void SetUIReady()
	{
	}

	public void OpenInventoryAtItem(UIPushOption pushOption, AccessoryDataClient displayShopItems)
	{
	}
}
