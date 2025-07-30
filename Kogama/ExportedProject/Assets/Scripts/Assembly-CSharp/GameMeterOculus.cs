using System;

public class GameMeterOculus : GameMeterKillBase
{
	private OculusKillLimitClient oculusClient;

	private int prevValue;

	public override GameMeterType GameMeterType => default(GameMeterType);

	public override void Initialize()
	{
	}

	private void OnVictoryConditionMet(object sender, EventArgs args)
	{
	}

	private void OnDestroy()
	{
	}

	public override void SetGameMeterVisibility()
	{
	}

	public override void UpdateValue()
	{
	}
}
