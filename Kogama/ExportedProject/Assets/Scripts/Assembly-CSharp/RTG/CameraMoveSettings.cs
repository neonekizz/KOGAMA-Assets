using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraMoveSettings : Settings
	{
		private static readonly float _minMoveSpeed;

		[SerializeField]
		private float _moveSpeed;

		[SerializeField]
		private float _accelerationRate;

		public float MoveSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AccelerationRate
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
