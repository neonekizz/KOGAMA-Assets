namespace GoogleMobileAds.Mediation.AppLovin.Common
{
	public interface IAppLovinClient
	{
		void Initialize();

		void SetHasUserConsent(bool hasUserConsent);

		void SetIsAgeRestrictedUser(bool isAgeRestrictedUser);

		void SetDoNotSell(bool doNotSell);
	}
}
