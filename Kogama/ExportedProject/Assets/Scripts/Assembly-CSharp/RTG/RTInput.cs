using UnityEngine;

namespace RTG
{
	public static class RTInput
	{
		public static Vector3 MousePosition => default(Vector3);

		public static bool IsMousePresent => false;

		public static int TouchCount => 0;

		public static bool WasLeftMouseButtonPressedThisFrame()
		{
			return false;
		}

		public static bool WasRightMouseButtonPressedThisFrame()
		{
			return false;
		}

		public static bool WasMiddleMouseButtonPressedThisFrame()
		{
			return false;
		}

		public static bool WasMouseButtonPressedThisFrame(int mouseButton)
		{
			return false;
		}

		public static bool WasMouseButtonReleasedThisFrame(int mouseButton)
		{
			return false;
		}

		public static bool IsLeftMouseButtonPressed()
		{
			return false;
		}

		public static bool IsRightMouseButtonPressed()
		{
			return false;
		}

		public static bool IsMiddleMouseButtonPressed()
		{
			return false;
		}

		public static bool IsMouseButtonPressed(int mouseButton)
		{
			return false;
		}

		public static bool WasMouseMoved()
		{
			return false;
		}

		public static float MouseAxisX()
		{
			return 0f;
		}

		public static float MouseAxisY()
		{
			return 0f;
		}

		public static float MouseScroll()
		{
			return 0f;
		}

		public static bool WasKeyPressedThisFrame(KeyCode keyCode)
		{
			return false;
		}

		public static bool IsKeyPressed(KeyCode keyCode)
		{
			return false;
		}

		public static Vector2 TouchDelta(int touchIndex)
		{
			return default(Vector2);
		}

		public static Vector2 TouchPosition(int touchIndex)
		{
			return default(Vector2);
		}

		public static bool TouchBegan(int touchIndex)
		{
			return false;
		}

		public static bool TouchEndedOrCanceled(int touchIndex)
		{
			return false;
		}

		public static bool TouchMoved(int touchIndex)
		{
			return false;
		}
	}
}
