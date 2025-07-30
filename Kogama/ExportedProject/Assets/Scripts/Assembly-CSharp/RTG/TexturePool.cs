using UnityEngine;

namespace RTG
{
	public class TexturePool : Singleton<TexturePool>
	{
		private Texture2D _xAxisLabel;

		private Texture2D _yAxisLabel;

		private Texture2D _zAxisLabel;

		private Texture2D _camPerspMode;

		private Texture2D _camOrthoMode;

		public Texture2D XAxisLabel => null;

		public Texture2D YAxisLabel => null;

		public Texture2D ZAxisLabel => null;

		public Texture2D CamPerspMode => null;

		public Texture2D CamOrthoMode => null;
	}
}
