using GoogleMobileAds.Mediation.AdColony.Api;

namespace GoogleMobileAds.Mediation.AdColony.Common
{
	public interface IAdColonyAppOptionsClient
	{
		void SetPrivacyFrameworkRequired(AdColonyPrivacyFramework privacyFramework, bool required);

		bool GetPrivacyFrameworkRequired(AdColonyPrivacyFramework privacyFramework);

		void SetPrivacyConsentString(AdColonyPrivacyFramework privacyFramework, string consentString);

		string GetPrivacyConsentString(AdColonyPrivacyFramework privacyFramework);

		void SetUserId(string userId);

		string GetUserId();

		void SetTestMode(bool isTestMode);

		bool IsTestMode();
	}
}
