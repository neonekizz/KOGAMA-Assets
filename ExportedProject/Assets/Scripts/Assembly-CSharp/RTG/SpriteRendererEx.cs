using UnityEngine;

namespace RTG
{
	public static class SpriteRendererEx
	{
		public static Vector3 GetWorldCenterPoint(this SpriteRenderer spriteRenderer)
		{
			return default(Vector3);
		}

		public static Vector3 GetModelSpaceSize(this SpriteRenderer spriteRenderer)
		{
			return default(Vector3);
		}

		public static AABB GetModelSpaceAABB(this SpriteRenderer spriteRenderer)
		{
			return default(AABB);
		}

		public static bool IsPixelFullyTransparent(this SpriteRenderer spriteRenderer, Vector3 worldPos)
		{
			return false;
		}
	}
}
