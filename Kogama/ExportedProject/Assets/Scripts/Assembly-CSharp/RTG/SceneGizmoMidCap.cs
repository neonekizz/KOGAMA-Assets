using UnityEngine;

namespace RTG
{
	public class SceneGizmoMidCap : SceneGizmoCap
	{
		public SceneGizmoMidCap(SceneGizmo sceneGizmo)
			: base(null, 0)
		{
		}

		public override void Render(Camera camera)
		{
		}

		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		private void OnGizmoHandlePicked(Gizmo gizmo, int handleId)
		{
		}
	}
}
