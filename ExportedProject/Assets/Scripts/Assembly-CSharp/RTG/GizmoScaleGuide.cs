using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoScaleGuide
	{
		private GizmoScaleGuideLookAndFeel _lookAndFeel;

		private GizmoScaleGuideLookAndFeel _sharedLookAndFeel;

		public GizmoScaleGuideLookAndFeel LookAndFeel => null;

		public GizmoScaleGuideLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Render(IEnumerable<GameObject> gameObjects, Camera camera)
		{
		}
	}
}
