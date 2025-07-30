using UnityEngine;

namespace RTG
{
	public class GizmoPolygonPlaneSlider2DController : GizmoPlaneSlider2DController
	{
		public GizmoPolygonPlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData)
			: base(null)
		{
		}

		public override void UpdateHandles()
		{
		}

		public override void UpdateEpsilons()
		{
		}

		public override void UpdateTransforms()
		{
		}

		public override Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
		}
	}
}
