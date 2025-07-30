using UnityEngine;

internal class ESSelection : ESStateBase
{
	private class PickResult<T>
	{
		public readonly Vector3 mousePosition;

		public readonly VoxelHit hit;

		public readonly T data;

		public PickResult(Vector3 mousePosition, VoxelHit hit, T data)
		{
		}
	}

	private EditorStateMachine editorStateMachine;

	private LinkObjectBase selectedLinkObject;

	private WorldObjectClientRef selectedWorldObject;

	private PickResult<WorldObjectClientRef> pickedTarget;

	private PickResult<LinkObjectBase> pickedLink;

	private ContextMenuController contextMenuController;

	private GizmoController gizmoController;

	public ESSelection(ContextMenuController contextMenuController, GizmoController gizmoController)
	{
	}

	private void ShowContextMenuGizmo()
	{
	}

	private void ShowLinkMenuGizmo()
	{
	}

	private void PopMenuGizmos()
	{
	}

	public override void Enter(EditorStateMachine e)
	{
	}

	private void DeselectAll(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	private void HandleDeleteSelection(EditorStateMachine e)
	{
	}

	private void HandleLeftClickDownSelection(EditorStateMachine e, VoxelHit targetHit, bool woPickSuccess)
	{
	}

	private void HandleLeftClickDragSelection(EditorStateMachine e, bool woPickSuccess)
	{
	}

	private void HandleLeftClickUpSelection(EditorStateMachine e)
	{
	}

	private void HandleRightClickDownSelection(EditorStateMachine e, VoxelHit targetHit, bool woPickSuccess)
	{
	}

	private void HandleRightClickUpSelection(EditorStateMachine e)
	{
	}

	public override void Exit(EditorStateMachine e)
	{
	}

	private bool IsMouseUpValid(Vector3 mousePosition)
	{
		return false;
	}

	private bool CheckAndExecuteOnClickHandler(EditorStateMachine e, PickResult<WorldObjectClientRef> pick)
	{
		return false;
	}

	private void SelectionController_SelectedWorldObjectDeletedHandler(object sender, WorldObjectDestroyedEventArgs e)
	{
	}

	private LinkObjectBase GetLinkHit(EditorStateMachine e, ref VoxelHit hit)
	{
		return null;
	}

	private bool EnterObject(EditorStateMachine e, MVWorldObjectClient selectedWo)
	{
		return false;
	}

	private void HandleEscapeSelection(EditorStateMachine e)
	{
	}
}
