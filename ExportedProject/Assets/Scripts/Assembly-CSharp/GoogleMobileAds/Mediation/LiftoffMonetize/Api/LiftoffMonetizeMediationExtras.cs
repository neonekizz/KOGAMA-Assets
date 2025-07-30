using GoogleMobileAds.Api.Mediation;

namespace GoogleMobileAds.Mediation.LiftoffMonetize.Api
{
	public abstract class LiftoffMonetizeMediationExtras : MediationExtrasLiftoff
	{
		public const string AllPlacementsKey = "all_placements";

		public const string UserIdKey = "user_id";

		public const string SoundEnabledKey = "sound_enabled";

		public override string IOSMediationExtraBuilderClassName => null;

		public LiftoffMonetizeMediationExtras()
		{
		}

		public void SetAllPlacements(string[] allPlacements)
		{
		}

		public void SetUserId(string userId)
		{
		}

		public void SetSoundEnabled(bool soundEnabled)
		{
		}
	}
}
