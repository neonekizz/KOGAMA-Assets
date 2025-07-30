using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModalNotification : Notification
{
	[SerializeField]
	private Text text;

	[SerializeField]
	private Image image;

	[SerializeField]
	private Sprite defaultSprite;

	private NotificationLifetime lifeTime;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}
}
