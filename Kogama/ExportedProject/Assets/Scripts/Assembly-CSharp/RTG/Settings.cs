using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public abstract class Settings
	{
		[SerializeField]
		private bool _canBeDisplayed;

		[SerializeField]
		protected bool _isExpanded;

		private string _foldoutLabel;

		public bool CanBeDisplayed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UsesFoldout { get; set; }

		public string FoldoutLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
