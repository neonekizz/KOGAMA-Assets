using UnityEngine;

namespace RTG
{
	public class GizmoLineMaterial : Singleton<GizmoLineMaterial>
	{
		private Material _material;

		public Material Material => null;

		public void ResetValuesToSensibleDefaults()
		{
		}

		public void SetColor(Color color)
		{
		}

		public void SetPass(int passIndex)
		{
		}

		public void SetZWriteEnabled(bool isEnabled)
		{
		}

		public void SetZTestLessEqual()
		{
		}

		public void SetZTestAlways()
		{
		}

		public void SetZTestLess()
		{
		}
	}
}
