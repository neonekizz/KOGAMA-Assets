public class TimeoutClock
{
	private readonly float timeoutTime;

	private float lastTimeout;

	public TimeoutClock(float timeoutTime)
	{
	}

	public bool IsInTimeout()
	{
		return false;
	}
}
