using GoogleMobileAds.Mediation.LiftoffMonetize.Api;

namespace GoogleMobileAds.Mediation.LiftoffMonetize.Common
{
	public class DummyClient : ILiftoffMonetizeClient
	{
		public void UpdateConsentStatus(VungleConsentStatus consentStatus, string consentMessageVersion)
		{
		}

		public void UpdateCCPAStatus(VungleCCPAStatus consentStatus)
		{
		}

		public void SetGDPRStatus(bool gdprStatus)
		{
		}

		public void SetGDPRMessageVersion(string gdprMessageVersion)
		{
		}

		public void SetCCPAStatus(bool ccpaStatus)
		{
		}
	}
}
