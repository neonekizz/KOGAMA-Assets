using MV.WorldObject;

public class InteractionDataHandler : InteractionDataHandlerBase
{
	public override MVTeam Team => default(MVTeam);

	public MVWorldObjectClient WorldObjectParent
	{
		set
		{
		}
	}

	public override bool HandleInteraction(MVPickupOwner interactor, InteractionData interaction, bool interactionIsLocal)
	{
		return false;
	}

	private bool IsDead(InteractionData interaction)
	{
		return false;
	}
}
