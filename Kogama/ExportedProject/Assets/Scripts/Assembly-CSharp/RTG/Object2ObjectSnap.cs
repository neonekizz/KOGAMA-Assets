using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class Object2ObjectSnap
	{
		[Flags]
		public enum Prefs
		{
			None = 0,
			TryMatchArea = 1,
			All = 1
		}

		public enum SnapFailReson
		{
			None = 0,
			MaxObjectsExceeded = 1,
			InvalidSourceObjects = 2,
			NoDestinationFound = 3
		}

		public struct SnapResult
		{
			private bool _success;

			private Vector3 _snapPivot;

			private Vector3 _snapDestination;

			private float _snapDistance;

			private SnapFailReson _failReason;

			public bool Success => false;

			public Vector3 SnapPivot => default(Vector3);

			public Vector3 SnapDestination => default(Vector3);

			public float SnapDistance => 0f;

			public SnapFailReson FailReason => default(SnapFailReson);

			public SnapResult(SnapFailReson failReson)
			{
				_success = false;
				_snapPivot = default(Vector3);
				_snapDestination = default(Vector3);
				_snapDistance = 0f;
				_failReason = default(SnapFailReson);
			}

			public SnapResult(Vector3 snapPivot, Vector3 snapDestination, float snapDistance)
			{
				_success = false;
				_snapPivot = default(Vector3);
				_snapDestination = default(Vector3);
				_snapDistance = 0f;
				_failReason = default(SnapFailReson);
			}
		}

		public struct Config
		{
			private float _areaMatchEps;

			public List<GameObject> IgnoreDestObjects;

			public int DestinationLayers;

			public float SnapRadius;

			public Prefs Prefs;

			public float AreaMatchEps
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}
		}

		private struct SnapSortData
		{
			public GameObject SrcObject;

			public GameObject DestObject;

			public BoxFace SrcSnapFace;

			public BoxFace DestSnapFace;

			public bool FaceAreasMatch;

			public float FaceAreaDiff;

			public Vector3 SnapPivot;

			public Vector3 SnapDest;

			public float SnapDistance;
		}

		private static List<GameObject> _nearbyObjectBuffer;

		private static Config _defaultConfig;

		public static int MaxSourceObjects => 0;

		public static Config DefaultConfig => default(Config);

		static Object2ObjectSnap()
		{
		}

		public static SnapResult Snap(List<GameObject> roots, Config snapConfig)
		{
			return default(SnapResult);
		}

		public static SnapResult Snap(GameObject root, Config snapConfig)
		{
			return default(SnapResult);
		}

		public static SnapResult CalculateSnapResult(GameObject root, Config snapConfig)
		{
			return default(SnapResult);
		}
	}
}
