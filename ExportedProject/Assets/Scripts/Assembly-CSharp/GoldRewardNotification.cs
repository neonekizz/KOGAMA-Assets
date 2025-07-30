using System.Collections.Generic;

public class GoldRewardNotification : Notification
{
	private NotificationLifetime lifeTime;

	protected override NotificationLifetime Lifetime => default(NotificationLifetime);

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	public void RewardClicked()
	{
	}
}
