namespace RTG
{
	public class GizmoCylindricalTorusCircle3DBorderController : GizmoCircle3DBorderController
	{
		public GizmoCylindricalTorusCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData)
			: base(null)
		{
		}

		public override void UpdateHandles()
		{
		}

		public override void UpdateEpsilons(float zoomFactor)
		{
		}

		public override void UpdateTransforms(float zoomFactor)
		{
		}

		public float GetTorusCoreRadius(float zoomFactor)
		{
			return 0f;
		}
	}
}
