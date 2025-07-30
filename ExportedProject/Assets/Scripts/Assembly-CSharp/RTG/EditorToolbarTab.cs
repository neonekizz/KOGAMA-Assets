using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class EditorToolbarTab
	{
		[SerializeField]
		private string _tooltip;

		[SerializeField]
		private string _text;

		[NonSerialized]
		private EditorToolbar _targetToolbar;

		[NonSerialized]
		private List<Settings> _targetSettings;

		public string Tooltip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EditorToolbar TargetToolbar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int NumTargetSettings => 0;

		public EditorToolbarTab(string text, string tooltip)
		{
		}

		public void AddTargetSettings(Settings targetSettings)
		{
		}
	}
}
