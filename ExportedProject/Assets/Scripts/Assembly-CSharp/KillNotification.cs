using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class KillNotification : Notification
{
	[SerializeField]
	private Text Label;

	[SerializeField]
	private Image Background;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	public static string GetKillText(Dictionary<object, object> data, bool shotSelf)
	{
		return null;
	}

	public static string GetKillText(PlayerKilledByType type, bool shotSelf, string weaponName)
	{
		return null;
	}
}
