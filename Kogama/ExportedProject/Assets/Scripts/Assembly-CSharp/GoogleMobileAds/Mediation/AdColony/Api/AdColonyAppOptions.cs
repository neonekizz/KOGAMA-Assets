using GoogleMobileAds.Mediation.AdColony.Common;

namespace GoogleMobileAds.Mediation.AdColony.Api
{
	public class AdColonyAppOptions
	{
		internal static readonly IAdColonyAppOptionsClient client;

		private static IAdColonyAppOptionsClient GetAdColonyAppOptionsClient()
		{
			return null;
		}

		public static void SetPrivacyFrameworkRequired(AdColonyPrivacyFramework privacyFramework, bool isRequired)
		{
		}

		public static bool GetPrivacyFrameworkRequired(AdColonyPrivacyFramework privacyFramework)
		{
			return false;
		}

		public static void SetPrivacyConsentString(AdColonyPrivacyFramework privacyFramework, string consentString)
		{
		}

		public static string GetPrivacyConsentString(AdColonyPrivacyFramework privacyFramework)
		{
			return null;
		}

		public static void SetUserId(string userId)
		{
		}

		public static string GetUserId()
		{
			return null;
		}

		public static void SetTestMode(bool isTestMode)
		{
		}

		public static bool IsTestMode()
		{
			return false;
		}
	}
}
