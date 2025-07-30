using UnityEngine;

public class NotificationSlideOut : MonoBehaviour
{
	[SerializeField]
	private Notification notification;

	[SerializeField]
	private Vector2 slideVelocity;

	[Range(0f, 1f)]
	[SerializeField]
	private float slideOutStartTime;

	private void OnValidate()
	{
	}

	protected void Update()
	{
	}
}
