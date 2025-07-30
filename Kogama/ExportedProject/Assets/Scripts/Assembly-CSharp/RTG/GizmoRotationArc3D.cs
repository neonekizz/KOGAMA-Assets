using UnityEngine;

namespace RTG
{
	public class GizmoRotationArc3D
	{
		private ArcShape3D _arc;

		public float RotationAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void SetArcData(Vector3 rotationAxis, Vector3 arcOrigin, Vector3 arcStart, float radius)
		{
		}

		public void Render(GizmoRotationArc3DLookAndFeel lookAndFeel)
		{
		}
	}
}
