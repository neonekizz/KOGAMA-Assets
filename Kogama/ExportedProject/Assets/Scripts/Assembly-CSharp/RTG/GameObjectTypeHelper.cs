using System.Collections.Generic;

namespace RTG
{
	public static class GameObjectTypeHelper
	{
		private static int _numTypes;

		private static List<GameObjectType> _allObjectTypes;

		private static GameObjectType _allCombined;

		public static int NumTypes => 0;

		public static GameObjectType[] AllObjectTypes => null;

		public static GameObjectType AllCombined => default(GameObjectType);

		static GameObjectTypeHelper()
		{
		}

		public static bool Is3DObjectType(GameObjectType objectType)
		{
			return false;
		}

		public static bool Is2DObjectType(GameObjectType objectType)
		{
			return false;
		}

		public static bool HasVolume(GameObjectType objectType)
		{
			return false;
		}

		public static bool IsTypeBitSet(int objectTypeMask, GameObjectType typeBit)
		{
			return false;
		}

		public static int SetTypeBit(int objectTypeMask, GameObjectType typeBit)
		{
			return 0;
		}

		public static int ClearTypeBit(int objectTypeMask, GameObjectType typeBit)
		{
			return 0;
		}
	}
}
