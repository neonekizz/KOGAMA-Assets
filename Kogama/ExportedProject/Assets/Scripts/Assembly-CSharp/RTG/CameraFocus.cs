using UnityEngine;

namespace RTG
{
	public static class CameraFocus
	{
		public class Data
		{
			private Vector3 _cameraWorldPosition;

			private Vector3 _focusPoint;

			private float _focusPointOffset;

			public Vector3 CameraWorldPosition => default(Vector3);

			public Vector3 FocusPoint => default(Vector3);

			public float FocusPointOffset => 0f;

			public Data(Vector3 cameraWorldPosition, Vector3 focusPoint)
			{
			}
		}

		public static Data CalculateFocusData(Camera camera, AABB focusAABB, CameraFocusSettings focusSettings)
		{
			return null;
		}
	}
}
