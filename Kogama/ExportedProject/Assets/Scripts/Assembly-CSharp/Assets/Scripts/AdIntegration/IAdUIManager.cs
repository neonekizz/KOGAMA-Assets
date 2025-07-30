using System;

namespace Assets.Scripts.AdIntegration
{
	public interface IAdUIManager
	{
		bool AdShowing();

		void ShowInterstitial(Action<InterstitialAdResult> callbackFunction);

		void ShowRewardedVideo(Action<RewardedAdResult> callbackFunction);

		void PopInterstitial(InterstitialAdResult adResult);

		void PopRewardedVideo(RewardedAdResult adResult);
	}
}
