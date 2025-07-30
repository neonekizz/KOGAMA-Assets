using UnityEngine;

namespace RTG
{
	public class GizmoSolidMaterial : Singleton<GizmoSolidMaterial>
	{
		private Material _material;

		public Material Material => null;

		public bool IsLit => false;

		public float LightIntensity => 0f;

		public void ResetValuesToSensibleDefaults()
		{
		}

		public void SetLit(bool isLit)
		{
		}

		public void SetLightDirection(Vector3 lightDir)
		{
		}

		public void SetLightIntensity(float intensity)
		{
		}

		public void SetColor(Color color)
		{
		}

		public void SetZWriteEnabled(bool isEnabled)
		{
		}

		public void SetZTestEnabled(bool isEnabled)
		{
		}

		public void SetZTestAlways()
		{
		}

		public void SetZTestLess()
		{
		}

		public void SetCullModeBack()
		{
		}

		public void SetCullModeFront()
		{
		}

		public void SetCullModeOff()
		{
		}

		public void SetPass(int passIndex)
		{
		}
	}
}
