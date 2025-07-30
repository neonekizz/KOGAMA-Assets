using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public class CameraBoxVignetteSettings : MonoBehaviour
	{
		public static class DataKeys
		{
			public const string VignetteOn = "ppVignOn";

			public const string Intensity = "ppVignInty";

			public const string Smoothness = "ppVignSmooth";

			public const string Roundness = "ppVignRness";

			public const string ColorR = "ppVignColR";

			public const string ColorG = "ppVignColG";

			public const string ColorB = "ppVignColB";

			public const string Rounded = "ppVignRnded";
		}

		public static class DefaultValues
		{
			public const bool VignetteOn = false;

			public const int Intensity = 0;

			public const int Smoothness = 2;

			public const int Roundness = 100;

			public const float ColorR = 0f;

			public const float ColorG = 0f;

			public const float ColorB = 0f;

			public const bool Rounded = false;
		}

		private static class MinMaxValues
		{
			public const int IntensityMin = 0;

			public const int IntensityMax = 100;

			public const int SmoothnessMin = 0;

			public const int SmoothnessMax = 100;

			public const int RoundnessMin = 0;

			public const int RoundnessMax = 100;
		}

		[SerializeField]
		private CameraBoxSettings cameraBoxSettings;

		[SerializeField]
		private SettingsToggle featureOnToggle;

		[SerializeField]
		private SettingsSlider intensitySlider;

		[SerializeField]
		private SettingsInputFieldSlider intensityInputField;

		[SerializeField]
		private SettingsSlider smoothnessSlider;

		[SerializeField]
		private SettingsInputFieldSlider smoothnessInputField;

		[SerializeField]
		private SettingsSlider roundnessSlider;

		[SerializeField]
		private SettingsInputFieldSlider roundnessInputField;

		[SerializeField]
		private SettingsToggle roundedToggle;

		[SerializeField]
		private Image colorImage;

		[SerializeField]
		private GameObject colorPicker;

		[SerializeField]
		private Image colorPickerPreview;

		[SerializeField]
		private SettingsSlider colorR;

		[SerializeField]
		private SettingsSlider colorG;

		[SerializeField]
		private SettingsSlider colorB;

		private void Start()
		{
		}

		public void OnSavePressed()
		{
		}

		public void OnColorPressed()
		{
		}

		public void OnColorEdited()
		{
		}

		public static void InitData(Dictionary<object, object> data)
		{
		}

		public static bool IsKey(string key)
		{
			return false;
		}

		public object ValueToSend(string key, object value)
		{
			return null;
		}
	}
}
