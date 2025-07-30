using UnityEngine;

public class LocalPositionAnimation : MonoBehaviour
{
	[SerializeField]
	private Vector3 deltaMovement;

	[Range(0.001f, 10f)]
	[SerializeField]
	private float animationTime;

	private Vector3 startPos;

	private Vector3 endPos;

	private float animatedTime;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
