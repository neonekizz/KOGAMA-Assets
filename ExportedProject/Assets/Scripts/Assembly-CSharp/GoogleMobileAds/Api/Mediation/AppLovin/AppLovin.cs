using System;
using GoogleMobileAds.Mediation.AppLovin.Common;

namespace GoogleMobileAds.Api.Mediation.AppLovin
{
	[Obsolete("Use `GoogleMobileAds.Mediation.AppLovin.Api.AppLovin` instead.")]
	public class AppLovin
	{
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

		private static IAppLovinClient GetAppLovinClient()
		{
			return null;
		}
	}
}
