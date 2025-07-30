using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Vehicles
{
	public class HamsterWheelSettings : VehicleBaseSettings, IHandleSettingChanged, IEventSystemHandler
	{
		public static readonly VehicleEnergyForVehicleSettingsConfig VehicleEnergyForVehicleSettingsConfig;

		protected override Vector2 DefaultCanvasSize => default(Vector2);

		public override void Initialize(GameObject root)
		{
		}

		public override Dictionary<object, object> FillDefaultBlueprintData()
		{
			return null;
		}

		public override void BlueprintDataRetrieved()
		{
		}

		public override VehicleEnergyForVehicleSettingsConfig GetVehicleEnergySettingsConfig()
		{
			return default(VehicleEnergyForVehicleSettingsConfig);
		}

		public void OnSettingChanged(string key, object value)
		{
		}
	}
}
