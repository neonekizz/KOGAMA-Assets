using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class CustomGunHitPackage : InteractionPackage
{
	private const PlayerKilledByType killedByType = PlayerKilledByType.CustomGun;

	public static InteractionData Create(float damage, Vector3 impulse)
	{
		return default(InteractionData);
	}

	public override void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct)
	{
	}
}
