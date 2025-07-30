using UGUI.Desktop.Scripts.PlayMode.InGameUI.Use;
using UnityEngine;

public class ShowUse3D : ShowUse
{
	[SerializeField]
	private GameObject canAfford;

	[SerializeField]
	private GameObject canNotAfford;

	[SerializeField]
	private TextWithIcon textWithIcon;

	private const ShowUseOption useButtonInsufficientOptions = ShowUseOption.GameCoinsInsufficient | ShowUseOption.LevelInsufficient | ShowUseOption.StarsInsufficient | ShowUseOption.TeamRestricted;

	public override void CalculateUseGraphics(ShowUseOption useOption, int woID = 0)
	{
	}

	public override void Hide()
	{
	}

	public override void Show()
	{
	}
}
