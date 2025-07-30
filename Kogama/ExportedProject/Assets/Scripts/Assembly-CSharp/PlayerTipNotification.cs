using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTipNotification : Notification
{
	[SerializeField]
	private Text tipText;

	[SerializeField]
	private NotificationFade fader;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}
}
