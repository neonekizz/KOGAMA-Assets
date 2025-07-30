using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class UniversalGizmoConfig : Settings
	{
		[SerializeField]
		private UniversalGizmoSettingsCategory _inheritCategory;

		[SerializeField]
		private UniversalGizmoSettingsType _inheritType;

		[SerializeField]
		private UniversalGizmoSettingsCategory _displayCategory;

		public UniversalGizmoSettingsCategory InheritCategory
		{
			get
			{
				return default(UniversalGizmoSettingsCategory);
			}
			set
			{
			}
		}

		public UniversalGizmoSettingsType InheritType
		{
			get
			{
				return default(UniversalGizmoSettingsType);
			}
			set
			{
			}
		}

		public UniversalGizmoSettingsCategory DisplayCategory
		{
			get
			{
				return default(UniversalGizmoSettingsCategory);
			}
			set
			{
			}
		}
	}
}
