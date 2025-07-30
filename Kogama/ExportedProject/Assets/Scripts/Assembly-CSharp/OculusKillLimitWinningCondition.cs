using UnityEngine;
using UnityEngine.UI;

public class OculusKillLimitWinningCondition : WinningConditionBase
{
	[SerializeField]
	private Image killImage;

	[SerializeField]
	private Text progress;

	[SerializeField]
	private ProgressBar progressBar;

	private int oculusKillLimit;

	protected override GameStatCounterType StatType => default(GameStatCounterType);

	public override void InitializeGameUI(RectTransform lobbyState)
	{
	}

	public override void UpdateValue(int newValue)
	{
	}

	public override void RoundEndReset()
	{
	}
}
