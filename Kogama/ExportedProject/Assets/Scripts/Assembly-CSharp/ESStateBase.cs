public class ESStateBase : IState
{
	protected EditorEvent stateType;

	private readonly ILogger logger;

	protected WorldObjectClientRef tintedWo;

	private MVWorldObjectClientManager WOCM => null;

	public void SetStateType(EditorEvent stateTypeEvent)
	{
	}

	public virtual void Enter(EditorStateMachine esm)
	{
	}

	public virtual void Execute(EditorStateMachine e)
	{
	}

	public virtual void Exit(EditorStateMachine esm)
	{
	}

	public void Enter(FSMEntity e)
	{
	}

	public void Execute(FSMEntity e)
	{
	}

	public void Exit(FSMEntity e)
	{
	}

	protected void DeTintCurrent()
	{
	}

	protected static bool SelectionIsAllowedByLogicEnabled(int woId)
	{
		return false;
	}

	protected void TintObjectsOnMouseOver(EditorStateMachine e)
	{
	}

	protected void TintObjectsOnMouseOver(EditorStateMachine e, bool pickSuccess, VoxelHit hit)
	{
	}
}
