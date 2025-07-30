using Gamestrap;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GradientEffect))]
[RequireComponent(typeof(Outline))]
[RequireComponent(typeof(ShadowEffect))]
[RequireComponent(typeof(Graphic))]
public class EffectStyleObject : MonoBehaviour
{
	[SerializeField]
	private EffectStyle effectStyle;

	[SerializeField]
	public Graphic graphic;

	[SerializeField]
	public ShadowEffect shadow;

	[SerializeField]
	public Outline outline;

	[SerializeField]
	public GradientEffect gradient;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	private void OnValidate()
	{
	}
}
