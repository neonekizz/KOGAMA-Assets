using UnityEngine;

namespace RTG
{
	public struct GizmoDragInfo
	{
		private bool _isDragged;

		private int _handleId;

		private Vector3 _dragBeginPoint;

		private GizmoDragChannel _dragChannel;

		private GizmoDimension _handleDimension;

		private Vector3 _totalOffset;

		private Quaternion _totalRotation;

		private Vector3 _totalScale;

		private Vector3 _relativeOffset;

		private Quaternion _relativeRotation;

		private Vector3 _relativeScale;

		public bool IsDragged
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

		public Vector3 DragBeginPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public GizmoDragChannel DragChannel
		{
			get
			{
				return default(GizmoDragChannel);
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

		public Vector3 TotalOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion TotalRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 TotalScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 RelativeOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion RelativeRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 RelativeScale
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
