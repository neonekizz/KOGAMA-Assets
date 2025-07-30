using System.Collections.Generic;
using ThemeAttributes;
using UnityEngine;

public abstract class CloudyThemeBase : Theme
{
	public static class SettingGroups
	{
		public const int all = 0;

		public const int dayNightCycleOn = 1;

		public const int dayNightCycleOff = 2;

		public const int realTimeOn = 4;

		public const int realTimeOff = 8;

		public const int fogEnabled = 16;

		public const int fogDisabled = 32;
	}

	[SerializeField]
	[Header("Day/night-cycle", order = 2)]
	[Header("Attributes", order = 1)]
	private BoolAttribute useDayNightCycle;

	[SerializeField]
	private BoolAttribute useServerTime;

	[SerializeField]
	private IntAttribute colorPreset;

	[SerializeField]
	private FloatAttribute gameStartTime;

	[SerializeField]
	private FloatAttribute cycleLength;

	[SerializeField]
	private FloatAttribute sunAltitude;

	[SerializeField]
	private FloatAttribute sunLongitude;

	[SerializeField]
	private FloatAttribute moonAltitude;

	[SerializeField]
	private FloatAttribute moonLongitude;

	[Header("Sky")]
	[SerializeField]
	private ColorAttribute topColor;

	[SerializeField]
	private ColorAttribute bottomColor;

	[Header("Stars")]
	[SerializeField]
	private ColorAttribute starsTint;

	[SerializeField]
	private FloatAttribute starsExtinction;

	[SerializeField]
	private FloatAttribute starsTwinkilingSpeed;

	[SerializeField]
	[Header("Sun")]
	private ColorAttribute sunTint;

	[SerializeField]
	private FloatAttribute sunSize;

	[SerializeField]
	private FloatAttribute sunHeight;

	[SerializeField]
	private FloatAttribute sunAxis;

	[SerializeField]
	private FloatAttribute sunLightContrast;

	[SerializeField]
	private FloatAttribute sunLightIntensity;

	[SerializeField]
	private FloatAttribute sunFlareBrightness;

	[Header("Moon")]
	[SerializeField]
	private ColorAttribute moonTint;

	[SerializeField]
	private FloatAttribute moonSize;

	[SerializeField]
	private FloatAttribute moonHeight;

	[SerializeField]
	private FloatAttribute moonAxis;

	[SerializeField]
	private FloatAttribute moonLightContrast;

	[SerializeField]
	private FloatAttribute moonLightIntensity;

	[SerializeField]
	private FloatAttribute moonFlareBrightness;

	[Header("Clouds")]
	[SerializeField]
	private FloatAttribute cloudsHeight;

	[SerializeField]
	private FloatAttribute cloudsOffset;

	[SerializeField]
	private FloatAttribute cloudsRotationSpeed;

	[SerializeField]
	[Header("Fog")]
	private BoolAttribute useFog;

	[SerializeField]
	private FloatAttribute fogDensity;

	[SerializeField]
	[Header("Misc")]
	private FloatAttribute exposure;

	[SerializeField]
	[Header("Dependencies")]
	private ThemeSkybox skybox;

	[SerializeField]
	private DayNightCycle dayNightCycle;

	[SerializeField]
	private DayNightCycleController cycleControllerPrefab;

	public override List<RectTransform> Controllers => null;

	public ThemeSkybox Skybox
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public override void ThemeReset()
	{
	}

	protected override void InitializeAttributes()
	{
	}

	protected override void InitializeComponents()
	{
	}

	private void ToggleDayNightCycle(bool b)
	{
	}

	private void ToggleDayNightCycleUseServerTime(bool b)
	{
	}

	private void ToggleFog(bool b)
	{
	}
}
