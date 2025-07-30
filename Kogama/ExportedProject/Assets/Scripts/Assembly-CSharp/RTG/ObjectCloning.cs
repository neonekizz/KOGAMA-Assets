using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class ObjectCloning
	{
		[Flags]
		public enum TransformFlags
		{
			None = 0,
			Position = 1,
			Rotation = 2,
			Scale = 4,
			All = 7
		}

		public struct Config
		{
			public Transform Parent;

			public TransformFlags TransformFlags;

			public int Layer;
		}

		private static Config _defaultConfig;

		public static Config DefaultConfig => default(Config);

		static ObjectCloning()
		{
		}

		public static List<GameObject> CloneHierarchies(List<GameObject> roots, Config cloneConfig)
		{
			return null;
		}

		public static GameObject CloneHierarchy(GameObject root, Config cloneConfig)
		{
			return null;
		}
	}
}
