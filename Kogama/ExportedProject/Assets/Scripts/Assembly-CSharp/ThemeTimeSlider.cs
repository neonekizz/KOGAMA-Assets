using System;
using ThemeAttributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThemeTimeSlider : FloatAttribute.Setter, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsSlider slider;

	[SerializeField]
	private Text label;

	[SerializeField]
	private Text timeText;

	private Action<float> onChange;

	private bool initialized;

	public override void Initialize(FloatAttribute attrib, Action<float> onChange)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
