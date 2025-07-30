using GoogleMobileAds.Mediation.LiftoffMonetize.Api;

namespace GoogleMobileAds.Mediation.LiftoffMonetize.Common
{
	public interface ILiftoffMonetizeClient
	{
		void UpdateConsentStatus(VungleConsentStatus consentStatus, string consentMessageVersion);

		void UpdateCCPAStatus(VungleCCPAStatus consentStatus);

		void SetGDPRStatus(bool gdprStatus);

		void SetGDPRMessageVersion(string gdprMessageVersion);

		void SetCCPAStatus(bool ccpaStatus);
	}
}
