using UnityEngine;

namespace RTG
{
	public class GizmoCircularMaterial : Singleton<GizmoCircularMaterial>
	{
		public enum Type
		{
			Circle = 0,
			Torus = 1,
			CylindricalTorus = 2
		}

		private Type _circularType;

		private Material _circleMaterial;

		private Material _torusMaterial;

		private Material _cylindricalTorusMaterial;

		public Material CircleMaterial => null;

		public Material TorusMaterial => null;

		public Material CylindricalTorusMaterial => null;

		public Material Material => null;

		public Type CircularType
		{
			get
			{
				return default(Type);
			}
			set
			{
			}
		}

		public bool IsLit => false;

		public float LightIntensity => 0f;

		public void ResetValuesToSensibleDefaults()
		{
		}

		public void SetCullAlphaScale(float scale)
		{
		}

		public void SetShapeCenter(Vector3 center)
		{
		}

		public void SetTorusCoreRadius(float radius)
		{
		}

		public void SetTorusTubeRadius(float radius)
		{
		}

		public void SetCylindricalTorusRadii(float hrzRadius, float vertRadius)
		{
		}

		public void SetCamera(Camera camera)
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
