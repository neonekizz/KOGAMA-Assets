using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoRotationArc3DLookAndFeel
	{
		[SerializeField]
		private bool _useShortestRotation;

		[SerializeField]
		private GizmoRotationArcFillFlags _fillFlags;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private Color _borderColor;

		public bool UseShortestRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GizmoRotationArcFillFlags FillFlags
		{
			get
			{
				return default(GizmoRotationArcFillFlags);
			}
			set
			{
			}
		}

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}
	}
}
