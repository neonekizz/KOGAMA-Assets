using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class XZGridSettings : Settings
	{
		[SerializeField]
		private bool _isVisible;

		[SerializeField]
		private float _cellSizeX;

		[SerializeField]
		private float _cellSizeZ;

		[SerializeField]
		private float _yOffset;

		[SerializeField]
		private Vector3 _rotationAngles;

		[SerializeField]
		private float _upDownStep;

		public bool IsVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float CellSizeX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CellSizeZ
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 RotationAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float YOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float UpDownStep
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
