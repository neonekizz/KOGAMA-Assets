using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class BoxColliderGizmo3DSettings
	{
		[SerializeField]
		private float _xSizeSnapStep;

		[SerializeField]
		private float _ySizeSnapStep;

		[SerializeField]
		private float _zSizeSnapStep;

		[SerializeField]
		private float _uniformSizeSnapStep;

		public static float DefaultSizeSnapStep => 0f;

		public static float DefaultUniformSizeSnapStep => 0f;

		public float XSizeSnapStep => 0f;

		public float YSizeSnapStep => 0f;

		public float ZSizeSnapStep => 0f;

		public float UniformSizeSnapStep => 0f;

		public void SetXSizeSnapStep(float snapStep)
		{
		}

		public void SetYSizeSnapStep(float snapStep)
		{
		}

		public void SetZSizeSnapStep(float snapStep)
		{
		}

		public void SetUniformSizeSnapStep(float snapStep)
		{
		}
	}
}
