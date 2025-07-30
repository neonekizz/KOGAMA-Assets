using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public abstract class LobbyFlowMenu : MonoBehaviour
{
	protected enum LobbyFlowMenuType
	{
		LobbyState = 0,
		Briefing = 1,
		Settings = 2,
		TeamSelect = 3,
		SpawnRoleSelect = 4,
		None = 5
	}

	[SerializeField]
	protected MaskMode cameraMaskMode;

	[SerializeField]
	protected ProfileSettingsMenu profileSettingsMenuPrefab;

	[SerializeField]
	protected TeamMenu teamMenuPrefab;

	[SerializeField]
	protected WinningConditionBriefing winningConditionBriefingMenuPrefab;

	[SerializeField]
	protected SpawnRoleMenu spawnRoleMenuPrefab;

	private bool haveSetSelectedTeam;

	protected MVTeam selectedTeam;

	private List<LobbyFlowMenuType> menuOrder;

	protected abstract LobbyFlowMenuType MenuType { get; }

	protected MVTeam SelectedTeam
	{
		set
		{
		}
	}

	public virtual void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected void UpdateAvailableMenues()
	{
	}

	protected virtual bool CanShowTeamSelect()
	{
		return false;
	}

	protected virtual bool CanShowBreifing()
	{
		return false;
	}

	protected virtual bool CanShowSpawnRoleSelect()
	{
		return false;
	}

	public void GoToNextMenu()
	{
	}

	public virtual void GoToPreviousMenu()
	{
	}

	protected bool CanGoToNextMenu()
	{
		return false;
	}

	protected LobbyFlowMenuType GetNextMenuType()
	{
		return default(LobbyFlowMenuType);
	}

	protected LobbyFlowMenuType GetPreviousMenuType()
	{
		return default(LobbyFlowMenuType);
	}

	protected void GoToMenu(LobbyFlowMenuType newMenuType)
	{
	}

	protected virtual void StartPlaying()
	{
	}
}
