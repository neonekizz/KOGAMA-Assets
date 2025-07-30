using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoObjectVertexSnapSettings : Settings
	{
		[SerializeField]
		private int _snapDestinationLayers;

		[SerializeField]
		private bool _canSnapToGrid;

		[SerializeField]
		private bool _canSnapToObjectVerts;

		public int SnapDestinationLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool CanSnapToGrid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CanSnapToObjectVerts
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsLayerSnapDestination(int objectLayer)
		{
			return false;
		}

		public void SetLayerSnapDestination(int objectLayer, bool isSnapDestination)
		{
		}

		public void Transfer(GizmoObjectVertexSnapSettings destination)
		{
		}
	}
}
