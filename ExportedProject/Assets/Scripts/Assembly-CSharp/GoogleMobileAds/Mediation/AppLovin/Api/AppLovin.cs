using GoogleMobileAds.Mediation.AppLovin.Common;

namespace GoogleMobileAds.Mediation.AppLovin.Api
{
	public class AppLovin
	{
		internal static readonly IAppLovinClient client;

		public static void Initialize()
		{
		}

		public static void SetHasUserConsent(bool hasUserConsent)
		{
		}

		public static void SetIsAgeRestrictedUser(bool isAgeRestrictedUser)
		{
		}

		public static void SetDoNotSell(bool doNotSell)
		{
		}

		internal static IAppLovinClient GetAppLovinClient()
		{
			return null;
		}
	}
}
