using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CapsuleColliderGizmo3DSettings
	{
		[SerializeField]
		private float _radiusSnapStep;

		[SerializeField]
		private float _heightSnapStep;

		public static float DefaultRadiusSnapStep => 0f;

		public static float DefaultHeightSnapStep => 0f;

		public float RadiusSnapStep => 0f;

		public float HeightSnapStep => 0f;

		public void SetRadiusSnapStep(float snapStep)
		{
		}

		public void SetHeightSnapStep(float snapStep)
		{
		}
	}
}
