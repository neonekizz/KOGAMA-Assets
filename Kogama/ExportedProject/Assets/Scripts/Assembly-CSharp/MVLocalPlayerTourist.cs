using System.Collections.Generic;
using MV.WorldObject.MetaData;

public class MVLocalPlayerTourist : MVLocalPlayer
{
	public static readonly Dictionary<string, string> Adjectives;

	public static readonly Dictionary<string, string> Nouns;

	public MVLocalPlayerTourist(int actorNumber, int profileID, string regionCode, int planetOwnershipTypeID, UserProfileData userProfileData)
		: base(0, 0, null, 0, null)
	{
	}
}
