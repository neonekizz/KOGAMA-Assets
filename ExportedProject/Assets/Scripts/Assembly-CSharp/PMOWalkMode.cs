internal class PMOWalkMode : PMOStateBase
{
	private enum EnterPlayFromObserveState
	{
		EnterObserveMode = 0,
		SelectTeamOrSpawnRole = 1,
		WaitForRoundToStart = 2
	}

	public override void Enter(PlayModeOnlyStateMachine psm)
	{
	}

	public override void Execute(PlayModeOnlyStateMachine psm)
	{
	}

	public override void Exit(PlayModeOnlyStateMachine psm)
	{
	}

	private void HandleEnterPlayInObserveMode()
	{
	}

	private EnterPlayFromObserveState CalculateEnterPlayFromObserveState()
	{
		return default(EnterPlayFromObserveState);
	}

	private bool ShouldSelectTeamOrSpawnRole(bool isSpawnRoleValid, bool isTeamValid)
	{
		return false;
	}

	private void HandleEnterState(EnterPlayFromObserveState enterState)
	{
	}

	private void HandleEnterPlayMode()
	{
	}

	private void HandleSelectTeamOrSpawnRole()
	{
	}

	private void HanldeWaitForRoundToStart()
	{
	}

	private void TryLockCursor()
	{
	}

	private void SetToHiddenMode()
	{
	}

	private bool WasPlayingAsDefaultAvatar()
	{
		return false;
	}

	private void OnNewSpawnRoleSelected(int newSpawnRoleId)
	{
	}
}
