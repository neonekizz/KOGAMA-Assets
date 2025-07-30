using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class SphereColliderGizmoSettings
	{
		[SerializeField]
		private float _radiusSnapStep;

		public static float DefaultRadiusSnapStep => 0f;

		public float RadiusSnapStep => 0f;

		public void SetRadiusSnapStep(float snapStep)
		{
		}
	}
}
