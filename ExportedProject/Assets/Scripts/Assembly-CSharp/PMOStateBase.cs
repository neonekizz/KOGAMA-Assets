public class PMOStateBase : IState
{
	protected PlayModeOnlyEvent stateType;

	private readonly ILogger logger;

	public void SetStateType(PlayModeOnlyEvent stateTypeEvent)
	{
	}

	public virtual void Enter(PlayModeOnlyStateMachine psm)
	{
	}

	public virtual void Execute(PlayModeOnlyStateMachine psm)
	{
	}

	public virtual void Exit(PlayModeOnlyStateMachine psm)
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
}
