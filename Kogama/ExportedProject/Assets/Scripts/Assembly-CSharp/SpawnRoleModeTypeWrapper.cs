using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.SpawnRoleVariableTypes;
using MV.Common;

public class SpawnRoleModeTypeWrapper
{
	private readonly SpawnRoleVariable<SpawnRoleModeType> spawnRoleType;

	public event Action<SpawnRoleModeType> OnChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public SpawnRoleModeTypeWrapper(SpawnRoleVariable<SpawnRoleModeType> spawnRoleType)
	{
	}

	public bool IsInMode(SpawnRoleModeType t)
	{
		return false;
	}

	private void OnChangeInternal(SpawnRoleModeType obj)
	{
	}
}
