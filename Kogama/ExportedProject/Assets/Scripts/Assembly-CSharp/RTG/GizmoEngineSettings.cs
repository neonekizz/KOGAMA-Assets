using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoEngineSettings : Settings
	{
		[SerializeField]
		private bool _enableGizmoSorting;

		public bool EnableGizmoSorting
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
