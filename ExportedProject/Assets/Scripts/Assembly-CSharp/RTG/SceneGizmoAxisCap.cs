using UnityEngine;

namespace RTG
{
	public class SceneGizmoAxisCap : SceneGizmoCap
	{
		private AxisDescriptor _axisDesc;

		private BoxFace _midAxisBoxFace;

		private GizmoTransform _zoomFactorTransform;

		private ColorRef _color;

		private ColorTransition _colorTransition;

		private Texture2D _labelTexture;

		public SceneGizmoAxisCap(SceneGizmo sceneGizmo, int id, AxisDescriptor gizmoAxisDesc)
			: base(null, 0)
		{
		}

		public override void Render(Camera camera)
		{
		}

		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		private void UpdateHoverPermission()
		{
		}

		private void UpdateColor()
		{
		}

		private void UpdateTransform(Camera camera)
		{
		}

		private void OnGizmoHandlePicked(Gizmo gizmo, int handleId)
		{
		}
	}
}
