using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes
{
	public class ObjectTransparencySettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
	{
		[SerializeField]
		private SettingsBase settingsBase;

		[SerializeField]
		private SettingsToggle toggle;

		[SerializeField]
		private SettingsSlider alphaSlider;

		[SerializeField]
		private SettingsInputFieldSlider alphaInputField;

		public void Initialize(int woID, GameObject root)
		{
		}

		private Dictionary<object, object> ReadWorldObjectData(Dictionary<object, object> woData)
		{
			return null;
		}

		public void OnSettingChanged(string key, object value)
		{
		}
	}
}
