using System.Collections.Generic;
using UnityEngine;

public class KillPrimaryNotification : Notification
{
	[SerializeField]
	private NotificationFade fader;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}
}
