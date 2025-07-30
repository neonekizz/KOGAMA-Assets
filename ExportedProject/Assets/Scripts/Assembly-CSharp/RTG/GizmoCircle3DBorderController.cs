namespace RTG
{
	public abstract class GizmoCircle3DBorderController : IGizmoCircle3DBorderController
	{
		protected GizmoCircle3DBorderControllerData _data;

		public GizmoCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData)
		{
		}

		public abstract void UpdateHandles();

		public abstract void UpdateEpsilons(float zoomFactor);

		public abstract void UpdateTransforms(float zoomFactor);
	}
}
