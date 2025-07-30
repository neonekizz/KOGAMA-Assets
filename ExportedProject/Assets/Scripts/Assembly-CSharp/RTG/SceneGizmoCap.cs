using UnityEngine;

namespace RTG
{
	public abstract class SceneGizmoCap
	{
		protected SceneGizmo _sceneGizmo;

		protected GizmoCap3D _cap;

		public int HandleId => 0;

		public Vector3 Position => default(Vector3);

		public SceneGizmoCap(SceneGizmo sceneGizmo, int capHandleId)
		{
		}

		public void SetHoverable(bool isHoverable)
		{
		}

		public abstract void Render(Camera camera);
	}
}
