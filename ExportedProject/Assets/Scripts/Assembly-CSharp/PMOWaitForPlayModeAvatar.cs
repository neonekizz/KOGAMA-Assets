using MV.WorldObject;

public class PMOWaitForPlayModeAvatar : PMOStateBase
{
	private enum EnterPlayFromObserveSpawnState
	{
		DefaultSpawnAsSpawnRole = 0,
		SpawnAsDefaultAvatar = 1,
		SpawnAsSelectedSpawnRole = 2
	}

	private bool defaultPlayModeSpawnRoleReady;

	private MVTeam selectedTeam;

	public override void Enter(PlayModeOnlyStateMachine psm)
	{
	}

	private void SpawnRolesManagerOnOnSpawnRoleActivated(int spawnRoleId)
	{
	}

	public override void Execute(PlayModeOnlyStateMachine psm)
	{
	}

	public override void Exit(PlayModeOnlyStateMachine psm)
	{
	}

	private EnterPlayFromObserveSpawnState CalculateEnterPlayFromObserveState()
	{
		return default(EnterPlayFromObserveSpawnState);
	}

	private bool IsTeamWithoutSpawnRole(bool teamsPresent, bool isTeamValid)
	{
		return false;
	}

	private bool IsSelectedSpawnRoleDeleted(bool isSpawnRoleValid, int selectedSpawnRoleCreatorId)
	{
		return false;
	}

	private bool ShouldEnterAsDefaultSpawnRole(bool isSpawnRoleValid, bool teamsPresent, int numberOfSpawnPoints)
	{
		return false;
	}

	private bool ShouldEnterAsSelectedSpawnRole(bool isSpawnRoleValid, bool spawnRolesPresent)
	{
		return false;
	}

	private void HandleEnterPlayModeFromObserveSpawn(EnterPlayFromObserveSpawnState enterSpawnState)
	{
	}

	private void HandleDefaultSpawnAsSpawnRole()
	{
	}

	private void HandleSpawnAsDefaultPlayModeSpawnRole()
	{
	}

	private void HanldeSpawnAsSelectedSpawnRole()
	{
	}

	private void SpawnAsSelectedSpawnRole(int spawnRoleId)
	{
	}

	private void SpawnAsDefaultPlayModeSpawnRole()
	{
	}

	private bool CanSpawnAsSelectedSpawnRole(int spawnRoleId)
	{
		return false;
	}
}
