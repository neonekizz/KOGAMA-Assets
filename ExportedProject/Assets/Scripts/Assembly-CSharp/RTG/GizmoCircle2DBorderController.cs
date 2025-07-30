namespace RTG
{
	public abstract class GizmoCircle2DBorderController : IGizmoCircle2DBorderController
	{
		protected GizmoCircle2DBorderControllerData _data;

		public GizmoCircle2DBorderController(GizmoCircle2DBorderControllerData data)
		{
		}

		public abstract void UpdateHandles();

		public abstract void UpdateEpsilons();

		public abstract void UpdateTransforms();
	}
}
