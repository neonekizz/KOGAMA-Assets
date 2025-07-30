using UnityEngine;

public class TimedObjectDestructor : MonoBehaviour
{
	[SerializeField]
	private float timeOut;

	[SerializeField]
	private bool detachChildren;

	private void Awake()
	{
	}

	private void DestroyNow()
	{
	}
}
