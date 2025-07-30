namespace RTG
{
	public abstract class GizmoPolygon2DBorderController : IGizmoPolygon2DBorderController
	{
		protected GizmoPolygon2DBorderControllerData _data;

		public GizmoPolygon2DBorderController(GizmoPolygon2DBorderControllerData data)
		{
		}

		public abstract void UpdateHandles();

		public abstract void UpdateEpsilons();

		public abstract void UpdateTransforms();
	}
}
