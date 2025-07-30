using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class TerrainGizmoSettings
	{
		[SerializeField]
		private float _offsetSnapStep;

		[SerializeField]
		private float _radiusSnapStep;

		[SerializeField]
		private float _rotationSensitivity;

		[SerializeField]
		private int _objectHrzMoveLayerMask;

		[SerializeField]
		private int _objectVertMoveLayerMask;

		[SerializeField]
		private int _objectRotationLayerMask;

		[SerializeField]
		private List<string> _objectHrzMoveIgnoreTags;

		[SerializeField]
		private List<string> _objectVertMoveIgnoreTags;

		[SerializeField]
		private List<string> _objectRotationIgnoreTags;

		public float OffsetSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RadiusSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RotationSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int ObjectHrzMoveLayerMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ObjectVertMoveLayerMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ObjectRotationLayerMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void AddObjectHrzMoveIgnoreTag(string tag)
		{
		}

		public bool IsTagIgnoredForHrzMove(string tag)
		{
			return false;
		}

		public void AddObjectVertMoveIgnoreTag(string tag)
		{
		}

		public bool IsTagIgnoredForVertMove(string tag)
		{
			return false;
		}

		public void AddObjectRotationIgnoreTag(string tag)
		{
		}

		public bool IsTagIgnoredForRotation(string tag)
		{
			return false;
		}
	}
}
