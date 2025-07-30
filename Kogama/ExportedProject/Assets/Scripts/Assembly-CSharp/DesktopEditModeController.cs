using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UGUI.Desktop.Scripts.EditMode.Inventories;
using UnityEngine;
using UnityEngine.EventSystems;

public class DesktopEditModeController : ModeControllerBase, IEditStateCommands, IEventSystemHandler, IEditModeUI, IGridSnapHandler, IEditModeController
{
	[CompilerGenerated]
	private sealed class _003CHandleCursorVisible_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CHandleCursorVisible_003Ed__66(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const float focusTimeInputSupressTimeOut = 5f;

	[SerializeField]
	private EditorWorldObjectCreation editorWorldObjectCreation;

	[SerializeField]
	private UIStack uiStack;

	[SerializeField]
	private InEditMenu inEditMenuPrefab;

	[SerializeField]
	private GameObject stackBottom;

	[SerializeField]
	private GameObject playModeButton;

	[SerializeField]
	private ChatControllerUGUI chatController;

	[SerializeField]
	private DrawPlaneControllerUUI drawPlaneController;

	[SerializeField]
	private MaterialsControllerEditMode materialsController;

	[SerializeField]
	private ContextMenuController contextMenuController;

	[SerializeField]
	private GizmoController gizmoController;

	[SerializeField]
	private EditModeRepositoryController repositoryController;

	[SerializeField]
	private EditModeClientShopController clientShopController;

	[SerializeField]
	private PlayerInventoryController playerInventoryController;

	[SerializeField]
	private CreateCubeModelController createCubeModelController;

	[SerializeField]
	private RectTransform notificationsManager;

	[SerializeField]
	private ChatBubbleController chatBubbleController;

	[SerializeField]
	private FirstTimeSetupTerrainEditTutorial firstTimeSetupTerrainEditTutorial;

	[SerializeField]
	private SetupCubeModelTutorialUI setupCubeModelTutorialUI;

	[SerializeField]
	private GoldPurchasedTracker goldPurchasedTracker;

	private float focusTime;

	private bool enterPlayModeOnceGuard;

	private bool enterBuildModeOnceGuard;

	private bool isInPlayInEditMode;

	private bool gridSnap;

	private bool canEdit;

	private bool canEnterPlayMode;

	private bool storedRenderLogicState;

	private bool focusSuppressInput;

	private Action<EditModeChangeArgs> editModeChange;

	private DesktopPlayModeController desktopPlayModeController;

	private PlayModeOnlyStateMachine playModeOnlyStateMachine;

	private InEditMenu inEditMenu;

	private FSMEntity stateMachine;

	public EditorStateMachine EditModeStateMachine { get; private set; }

	public bool IsInPlayInEditMode => false;

	public PlayerShopInventoryRepository PlayerShopInventoryRepository { get; set; }

	public Action<EditModeChangeArgs> EditModeChange
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void HandleFocusInputSuppress()
	{
	}

	private void Update()
	{
	}

	private void HandleInput()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	public void RegisterPlayModeController(DesktopPlayModeController desktopPlayModeController)
	{
	}

	private bool CanEdit()
	{
		return false;
	}

	private bool CanEnterPlayMode()
	{
		return false;
	}

	public override void Initialize()
	{
	}

	private void InitializeEditSystems()
	{
	}

	private void InitializePlayModeSystems()
	{
	}

	private void DestroyFirstTimeEditTutorials()
	{
	}

	private void HideUI()
	{
	}

	public void DisableEditMode()
	{
	}

	public void EnterPlayMode()
	{
	}

	private void LeaveEditPlayMode()
	{
	}

	public void EnterBuildMode()
	{
	}

	public void SetState(EditorEvent editorEvent)
	{
	}

	public void SetState(PlayModeOnlyEvent playModeOnlyEvent)
	{
	}

	public void ClearStateStack()
	{
	}

	[IteratorStateMachine(typeof(_003CHandleCursorVisible_003Ed__66))]
	private IEnumerator HandleCursorVisible()
	{
		return null;
	}

	public bool IsGridSnap()
	{
		return false;
	}

	public void Set(bool snap)
	{
	}

	private void RegisterShortcuts()
	{
	}

	public void Respawn()
	{
	}

	public void MoveToSelectedObject()
	{
	}

	public void DeleteWoid(int woid)
	{
	}

	public void SetUIReady()
	{
	}
}
