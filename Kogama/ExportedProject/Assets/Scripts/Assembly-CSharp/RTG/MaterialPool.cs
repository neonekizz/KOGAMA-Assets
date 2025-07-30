using UnityEngine;

namespace RTG
{
	public class MaterialPool : Singleton<MaterialPool>
	{
		private Material _linearGradientCameraBk;

		private Material _xzGrid_Plane;

		private Material _gizmoSolidHandle;

		private Material _tintedTexture;

		private Material _simpleColor;

		private Material _circleCull;

		private Material _torusCull;

		private Material _cylindricalTorusCull;

		public Material LinearGradientCameraBk => null;

		public Material XZGrid_Plane => null;

		public Material GizmoSolidHandle => null;

		public Material TintedTexture => null;

		public Material SimpleColor => null;

		public Material CircleCull => null;

		public Material TorusCull => null;

		public Material CylindricalTorusCull => null;
	}
}
