using UnityEngine;

namespace RTG
{
	public class ShaderPool : Singleton<ShaderPool>
	{
		private Shader _linearGradientCameraBk;

		private Shader _xzGrid_Plane;

		private Shader _gizmoSolidHandle;

		private Shader _tintedTexture;

		private Shader _simpleColor;

		private Shader _circleCull;

		private Shader _torusCull;

		private Shader _cylindricalTorusCull;

		public Shader LinearGradientCameraBk => null;

		public Shader XZGrid_Plane => null;

		public Shader GizmoSolidHandle => null;

		public Shader TintedTexture => null;

		public Shader SimpleColor => null;

		public Shader CircleCull => null;

		public Shader TorusCull => null;

		public Shader CylindricalTorusCull => null;
	}
}
