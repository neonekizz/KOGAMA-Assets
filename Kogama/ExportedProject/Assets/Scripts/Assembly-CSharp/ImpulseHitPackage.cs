using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class ImpulseHitPackage : InteractionPackage
{
	private readonly Dictionary<int, float> lastShotTime;

	private const float MinImpulseEffect = 0.5f;

	private const float MaxImpulseMagnitude = 3000f;

	public static InteractionData Create(Vector3 impulse)
	{
		return default(InteractionData);
	}

	public override void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct)
	{
	}
}
