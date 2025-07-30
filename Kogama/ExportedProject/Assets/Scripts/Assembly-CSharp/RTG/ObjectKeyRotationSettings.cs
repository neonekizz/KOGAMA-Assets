using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class ObjectKeyRotationSettings : Settings
	{
		[SerializeField]
		private float _xRotationStep;

		[SerializeField]
		private float _yRotationStep;

		[SerializeField]
		private float _zRotationStep;

		public float XRotationStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float YRotationStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ZRotationStep
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
}
