using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.UGUI.Desktop.Scripts.EditMode.SettingsBoxes
{
	public abstract class SettingsUI : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
	{
		[Space(15f)]
		[SerializeField]
		[Header("Base settings serialized fields")]
		protected RectTransform canvas;

		[SerializeField]
		protected SettingsBase settingsBase;

		[SerializeField]
		protected GameObject content;

		[SerializeField]
		protected GameObject colorPicker;

		[SerializeField]
		protected Text colorText;

		[SerializeField]
		protected Image colorPickerPreview;

		[SerializeField]
		protected SettingsSlider colorR;

		[SerializeField]
		protected SettingsSlider colorG;

		[SerializeField]
		protected SettingsSlider colorB;

		[SerializeField]
		protected SettingsSlider colorA;

		protected Dictionary<object, object> data;

		protected string editingColorKey;

		protected Dictionary<object, object> itemData;

		protected virtual Vector2 NormalEditingCanvasSize => default(Vector2);

		protected virtual Vector2 ColorEditingCanvasSize => default(Vector2);

		protected virtual Dictionary<object, object> DefaultItemData { get; set; }

		public abstract void Initialize(int woID, GameObject root);

		protected abstract Dictionary<object, object> ReadWorldObjectItemData(Dictionary<object, object> woData);

		protected void InitializeSlider(SettingsSlider slider, string key, Func<string, (int, int)> minMax)
		{
		}

		public virtual void OnSettingChanged(string key, object value)
		{
		}

		public virtual void OnColorPressed(string colorKey)
		{
		}

		private void UpdateColorPickerPreview()
		{
		}

		public virtual void OnColorEdited()
		{
		}

		protected List<int> GetAcceptableIndexes(int size)
		{
			return null;
		}
	}
}
