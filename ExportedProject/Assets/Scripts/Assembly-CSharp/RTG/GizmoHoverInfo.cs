using UnityEngine;

namespace RTG
{
	public struct GizmoHoverInfo
	{
		private bool _isHovered;

		private int _handleId;

		private GizmoDimension _handleDimension;

		private Vector3 _hoverPoint;

		public bool IsHovered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int HandleId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GizmoDimension HandleDimension
		{
			get
			{
				return default(GizmoDimension);
			}
			set
			{
			}
		}

		public Vector3 HoverPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public void Reset()
		{
		}
	}
}
