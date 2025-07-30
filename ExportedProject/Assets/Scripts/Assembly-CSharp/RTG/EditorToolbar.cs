using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class EditorToolbar
	{
		[SerializeField]
		private Color _activeTabColor;

		[SerializeField]
		private int _numTabsPerRow;

		[SerializeField]
		private EditorToolbarTab[] _tabs;

		[SerializeField]
		private int _activeTabIndex;

		public int ActiveTabIndex => 0;

		public EditorToolbarTab ActiveTab => null;

		public Color ActiveTabColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int NumTabsPerRow
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int NumTabs => 0;

		public EditorToolbar(EditorToolbarTab[] tabs, int numTabsPerRow, Color activeTabColor)
		{
		}

		public EditorToolbarTab GetTabByIndex(int tabIndex)
		{
			return null;
		}
	}
}
