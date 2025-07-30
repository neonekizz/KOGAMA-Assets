using System;
using Assets.Scripts.AdIntegration;

namespace AdIntegration.Dummy
{
	public class DummyAdManager : IAdManager, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
	{
		public const bool PortalUIRealAdManagerInEditor = true;

		private IAdUIManager adUIHandler;

		private float startTime;

		private readonly float delay;

		private bool rewarded;

		private EmbeddedSiteConfigData siteData;

		private bool timeoutAsEnabled;

		private int timeoutSuccessDelay;

		public string RewardedAdNotAvailableText => null;

		public TimeSpan TimeSinceLastAd => default(TimeSpan);

		public TimeSpan TimeSinceLastInterstitial => default(TimeSpan);

		public TimeSpan TimeSinceLastRewarded => default(TimeSpan);

		public bool ReadyForRewardedAdRequest => false;

		public bool ReadyForInterstitialAdRequest => false;

		public void InitializeAdConfigSettings(AdConfigSettings config)
		{
		}

		public bool HideFullscreen()
		{
			return false;
		}

		public void InitializeCallbackManager(IAdUIManager handler)
		{
		}

		public void RequestRewardedAd(Action<RewardedAdResult> rewardedAdCallback, AdContext context)
		{
		}

		public void RequestInterstitial(Action<InterstitialAdResult> interstitialCallback, AdContext context)
		{
		}

		public void UpdateControllerUpdate()
		{
		}
	}
}
