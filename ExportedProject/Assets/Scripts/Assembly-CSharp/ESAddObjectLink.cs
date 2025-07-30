using MV.WorldObject;

internal class ESAddObjectLink : ESStateBase
{
	private ObjectLink tempLink;

	private WorldObjectClientRef woRef;

	public override void Enter(EditorStateMachine esm)
	{
	}

	public override void Execute(EditorStateMachine esm)
	{
	}

	private void LeaveAddLinkAndDeSelectAll(EditorStateMachine esm)
	{
	}

	private void LeaveAddLink(EditorStateMachine esm)
	{
	}

	public override void Exit(EditorStateMachine esm)
	{
	}

	private bool DoAddLink()
	{
		return false;
	}
}
