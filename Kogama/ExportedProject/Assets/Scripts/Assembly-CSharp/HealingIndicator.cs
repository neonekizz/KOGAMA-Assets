using UnityEngine;
using UnityEngine.UI;

public class HealingIndicator : MonoBehaviour
{
	[SerializeField]
	private Image healthOverlay;

	[SerializeField]
	private AnimationCurve curve;

	private float timer;

	private float animationDuration;

	private float targetTime;

	private void Awake()
	{
	}

	public void ShowHealing(float healingAmount, MVPlayer healer)
	{
	}

	private void Update()
	{
	}
}
