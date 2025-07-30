namespace RTG
{
	public class GizmoHandleShape2D
	{
		private bool _isVisible;

		private bool _isHoverable;

		private Shape2D _shape;

		public Shape2D Shape => null;

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

		public GizmoHandleShape2D(Shape2D shape)
		{
		}
	}
}
