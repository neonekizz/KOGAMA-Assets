namespace RTG
{
	public class GizmoHandleShape3D
	{
		private bool _isVisible;

		private bool _isHoverable;

		private Shape3D _shape;

		public Shape3D Shape => null;

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

		public bool IsHoverable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GizmoHandleShape3D(Shape3D shape)
		{
		}
	}
}
