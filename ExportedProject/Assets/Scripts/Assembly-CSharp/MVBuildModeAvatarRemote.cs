using System.Collections.Generic;
using MV.WorldObject.OwnershipData;
using UnityEngine;

public class MVBuildModeAvatarRemote : MVBuildModeAvatar, ISpawnRoleRemote
{
	private LaserPointer laserPointer;

	private readonly AvatarRemoteBuildMode avatarRemoteBuildMode;

	private readonly DynamicCullingHandler cullingHandler;

	int ISpawnRoleRemote.Id => 0;

	public MVBuildModeAvatarRemote(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void InitializeLaserPointerAndEditCube()
	{
	}

	private void RecievedPlanetOwnershipDataCallback(Dictionary<int, PlanetOwnershipsEntry> planetOwnershipsEntries)
	{
	}

	private void HandleLaserActive(bool isLocal, bool isActive)
	{
	}

	public override void Destroy()
	{
	}

	public void Activate(int idFrom, Vector3 position, Quaternion rotation)
	{
	}

	public void DeActivate(int idTo)
	{
	}

	private void SetLaserPointerVisibility(bool isVisible)
	{
	}

	protected override Vector3 GetLookDirection()
	{
		return default(Vector3);
	}
}
