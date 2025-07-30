namespace RTG
{
	public abstract class GizmoScreenDrag : GizmoDragSession
	{
		private bool _isSnapEnabled;

		private float _sensitivity;

		protected InputDeviceScreenDragSession _screenDragSession;

		public bool IsSnapEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Sensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool IsActive => false;

		protected override bool DoBeginSession()
		{
			return false;
		}

		protected override bool DoUpdateSession()
		{
			return false;
		}

		protected override void DoEndSession()
		{
		}

		protected bool CanSnap()
		{
			return false;
		}
	}
}
