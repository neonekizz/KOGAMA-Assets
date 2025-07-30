using UnityEngine;
using UnityEngine.UI;

public class CollectiblesWinningCondition : WinningConditionBase
{
	[SerializeField]
	private Image starImage;

	[SerializeField]
	private Text progress;

	[SerializeField]
	private ProgressBar progressBar;

	private int amountOfStars;

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
