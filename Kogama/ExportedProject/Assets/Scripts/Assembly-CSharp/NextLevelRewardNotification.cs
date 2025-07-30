using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelRewardNotification : Notification
{
	[SerializeField]
	private Text goldAmount;

	[SerializeField]
	private Text levelText;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}
}
