using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LevelUpNotification : Notification
{
	[SerializeField]
	private Text label;

	[SerializeField]
	private Image Icon;

	private Texture2D textureAsset;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	private void OnDestroy()
	{
	}

	private void BadgeCallback(UnityWebRequest www)
	{
	}
}
