using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TierUnlockedNotification : Notification
{
	[SerializeField]
	private Text tierUnlockedText;

	[SerializeField]
	private NotificationSlideOut slider;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	protected override void Update()
	{
	}
}
