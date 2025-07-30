using Gamestrap;
using UnityEngine;
using UnityEngine.UI;

public class XPNotificationBoostedBehaviour : MonoBehaviour
{
	[SerializeField]
	private Text xpText;

	[SerializeField]
	private Text unboostedXpText;

	[SerializeField]
	private ProgressBar xpFillBar;

	[SerializeField]
	private ProgressBar xpFillBarBackground;

	[SerializeField]
	private RectTransform boostEffectTransform;

	[SerializeField]
	private GradientEffect arrowGradientEffect;

	[SerializeField]
	private GameObject glowEffectGameObject;

	[SerializeField]
	private XpBoostParticlePreviewer xpBoostParticlesPreviewPrefab;

	[SerializeField]
	private RawImage xpBoostParticlesRawImage;

	[SerializeField]
	private AnimationCurve boostEffectCurve;

	[SerializeField]
	private AnimationCurve glowEffectCurve;

	[SerializeField]
	private AnimationCurve gradientEffectCurve;

	[SerializeField]
	private float slideOutSpeed;

	private const float fillImageFillingStartTime = 1.125f;

	private const float fillImageFillingFinishTime = 2.29167f;

	private const float fillImageBackgroundFillingStartTime = 1f;

	private const float fillImageBackgroundFillingFinishTime = 2.29167f;

	private const float boostEffectsStartTime = 1.2f;

	private const float gradientEffectsStartTime = 1.2f;

	private const float glowEffectStartTime = 1.7817f;

	private const float glowEnableTime = 2.28167f;

	private const float slideOutBoostEffectsStartTime = 2.29167f;

	private const float boostParticlesStartTime = 1.2f;

	private const float gradientEffectTopDelay = 0.125f;

	private float boostEffectStatPositionX;

	private float startTime;

	private XpBoostParticlePreviewer xpBoostParticlesPreview;

	public void Initialize(int boostedXPAmount, int unboostedXpAmount)
	{
	}

	private void Update()
	{
	}

	private void DoFillImageFillingEffect(float timeSinceStart)
	{
	}

	private void DoBoostEffect(float timeSinceStart)
	{
	}

	private void DoGlowEffect(float timeSinceStart)
	{
	}

	private void DoGradientEffect(float timeSinceStart)
	{
	}

	private void DoSlideOutEffect()
	{
	}

	private void DoParticleEffect()
	{
	}

	private void Reset()
	{
	}
}
