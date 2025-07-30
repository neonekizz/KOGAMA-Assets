using UnityEngine;

namespace Misc
{
	public class OrientationControl : MonoBehaviour
	{
		[SerializeField]
		private GameObject orientationWarningOverlay;

		[SerializeField]
		private bool printOrientation;

		[SerializeField]
		private bool toggleShowWarning;

		private bool takeAction;

		private MVOrientation desiredOrientation;

		private static bool debugging;

		public static MVOrientation CurrentOrientation => default(MVOrientation);

		private static void PrintLog(string s)
		{
		}

		private static MVOrientation MapFromResolution(int width, int height)
		{
			return default(MVOrientation);
		}

		private static MVOrientation MapFromDeviceOrientation(DeviceOrientation deviceOrientation)
		{
			return default(MVOrientation);
		}

		private static MVOrientation MapFromScreenOrientation(ScreenOrientation screenOrientation)
		{
			return default(MVOrientation);
		}

		private void Start()
		{
		}
	}
}
