using UnityEngine;

namespace RTG
{
	public class GizmoBoxLineSlider3DController : GizmoLineSlider3DController
	{
		public GizmoBoxLineSlider3DController(GizmoLineSlider3DControllerData controllerData)
			: base(null)
		{
		}

		public override void UpdateHandles()
		{
		}

		public override void UpdateTransforms(float zoomFactor)
		{
		}

		public override void UpdateEpsilons(float zoomFactor)
		{
		}

		public override float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor)
		{
			return 0f;
		}
	}
}
