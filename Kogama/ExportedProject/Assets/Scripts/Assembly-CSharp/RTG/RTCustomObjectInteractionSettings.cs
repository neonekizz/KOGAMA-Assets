using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class RTCustomObjectInteractionSettings : Settings
	{
		[SerializeField]
		private Vector3 _noVolumeObjectSize;

		public Vector3 NoVolumeObjectSize
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}
	}
}
