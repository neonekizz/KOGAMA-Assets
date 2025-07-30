using System.Collections.Generic;
using MV.Common;

public class GameMessages
{
	public struct PlayerJoinMessage
	{
		public int playerId;
	}

	public struct PlayerLeftMessage
	{
		public int playerId;

		public string userName;
	}

	public struct CollectibleMessage
	{
		public int playerId;
	}

	public struct AchievementGetMessage
	{
		public int playerId;

		public AchievementType achievementType;
	}

	public struct CheckpointMessage
	{
		public int playerID;
	}

	public static Dictionary<object, object> MakePlayerKilledMessage(int avatarId, int killerId, PlayerKilledByType weaponType)
	{
		return null;
	}

	public static PlayerJoinMessage ParsePlayerJoinMessage(Dictionary<object, object> package)
	{
		return default(PlayerJoinMessage);
	}

	public static PlayerLeftMessage ParsePlayerLeftMessage(Dictionary<object, object> package)
	{
		return default(PlayerLeftMessage);
	}

	public static CollectibleMessage ParseCollectibleMessage(Dictionary<object, object> package)
	{
		return default(CollectibleMessage);
	}

	public static AchievementGetMessage ParseAchievementGetMessage(Dictionary<object, object> package)
	{
		return default(AchievementGetMessage);
	}

	public static CheckpointMessage ParseCheckpointMessage(Dictionary<object, object> package)
	{
		return default(CheckpointMessage);
	}
}
