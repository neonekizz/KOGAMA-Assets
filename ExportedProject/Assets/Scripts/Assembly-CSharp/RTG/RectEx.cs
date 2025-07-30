using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class RectEx
	{
		public static List<Vector2> GetCornerPoints(this Rect rect)
		{
			return null;
		}

		public static Rect PlaceBelowCenterHrz(this Rect rect, Rect other)
		{
			return default(Rect);
		}

		public static Rect InvertScreenY(this Rect rect)
		{
			return default(Rect);
		}

		public static Rect FromCenterAndSize(Vector2 center, Vector2 size)
		{
			return default(Rect);
		}

		public static Rect FromPoints(IEnumerable<Vector2> points)
		{
			return default(Rect);
		}

		public static Rect FromTexture2D(Texture2D texture2D)
		{
			return default(Rect);
		}

		public static Rect Inflate(this Rect rect, float inflateAmount)
		{
			return default(Rect);
		}

		public static bool ContainsAllPoints(this Rect rect, IEnumerable<Vector2> points)
		{
			return false;
		}
	}
}
