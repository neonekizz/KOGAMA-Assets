using MV.WorldObject;

public class MouseGunHitPackage : InteractionPackage
{
	public static InteractionData Create()
	{
		return default(InteractionData);
	}

	public override void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct)
	{
	}
}
