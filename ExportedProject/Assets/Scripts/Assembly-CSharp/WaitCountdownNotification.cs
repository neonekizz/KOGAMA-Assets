using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitCountdownNotification : Notification
{
	[SerializeField]
	private Text countdownText;

	[SerializeField]
	private NotificationFade countDownFader;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	protected override void Update()
	{
	}

	private void DestroyNotification()
	{
	}
}
