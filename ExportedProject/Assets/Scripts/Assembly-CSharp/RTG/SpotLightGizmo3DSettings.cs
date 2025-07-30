using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class SpotLightGizmo3DSettings
	{
		[SerializeField]
		private float _radiusSnapStep;

		[SerializeField]
		private float _rangeSnapStep;

		public static float DefaultRadiusSnapStep => 0f;

		public static float DefaultRangeSnapStep => 0f;

		public float RadiusSnapStep => 0f;

		public float RangeSnapStep => 0f;

		public void SetRadiusSnapStep(float snapStep)
		{
		}

		public void SetRangeSnapStep(float snapStep)
		{
		}
	}
}
