using UnityEngine;

public class ImageScaleAnimator : MonoBehaviour
{
	[SerializeField]
	private RectTransform scaleTarget;

	[SerializeField]
	[Tooltip("Scale negative for downscaling")]
	private AnimationCurve scaleCurve;

	[SerializeField]
	private float scaleSpeed;

	private Vector2 startSize;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
