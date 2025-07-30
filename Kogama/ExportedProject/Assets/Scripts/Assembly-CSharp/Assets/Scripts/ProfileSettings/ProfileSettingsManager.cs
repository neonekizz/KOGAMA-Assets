using System;
using System.Collections.Generic;
using MV.WorldObject.MetaData;
using UnityEngine;

namespace Assets.Scripts.ProfileSettings
{
	public static class ProfileSettingsManager
	{
		private const float mouseSenseMinModifier = 10f;

		private const float mouseSenseMaxModifier = 10f;

		public static Dictionary<ProfileSettingKey, Action<object>> ProfileSettingsChanged;

		public static float mouseSensitivity;

		public static SettingsPlatform SettingsPlatform => default(SettingsPlatform);

		public static TargetFrameRateValue TargetFrameRate { get; private set; }

		public static TextureQualityLevel TextureQualityLevel { get; private set; }

		public static FilterMode TextureFilter { get; private set; }

		public static AnistropicFilteringLevel AnistropicFilteringLevel { get; private set; }

		public static LightingQualityLevel LightQualityLevel { get; private set; }

		public static AntiAliasingLevel AntiAliasingLevel { get; private set; }

		public static void Init(ProfileSettingsState profileSettingsState)
		{
		}

		public static void InitTourist()
		{
		}

		public static object GetSettingValue(ProfileSettingKey profileSetting)
		{
			return null;
		}

		public static void SetSettingValue(ProfileSettingKey profileSetting, object value)
		{
		}

		public static void ResetToDefaultValues()
		{
		}

		public static int TargetFrameRateToInt(TargetFrameRateValue value)
		{
			return 0;
		}

		public static int TargetFrameRateToVSyncValue(TargetFrameRateValue value)
		{
			return 0;
		}

		public static int AnisoLevelToInt(AnistropicFilteringLevel level)
		{
			return 0;
		}

		private static int AntiAliasingLevelToInt(AntiAliasingLevel level)
		{
			return 0;
		}

		private static float CalculateMouseSensitivityFromValue(float value)
		{
			return 0f;
		}

		private static void SetFrameRateSetting(TargetFrameRateValue value)
		{
		}

		private static void SetFrameRateDesktop(TargetFrameRateValue value)
		{
		}

		private static void SetFrameRateTouch(TargetFrameRateValue value)
		{
		}

		private static void SetLightQualitySetting(LightingQualityLevel level)
		{
		}
	}
}
