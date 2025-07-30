using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class SceneGizmo : GizmoBehaviour, ISceneGizmo
	{
		private SceneGizmoCamPrjSwitchLabel _camPrjSwitchLabel;

		private SceneGizmoMidCap _midAxisHandle;

		private SceneGizmoAxisCap[] _axesHandles;

		private List<SceneGizmoCap> _renderSortedHandles;

		private RTSceneGizmoCamera _sceneGizmoCamera;

		[SerializeField]
		private SceneGizmoLookAndFeel _lookAndFeel;

		[SerializeField]
		private SceneGizmoLookAndFeel _sharedLookAndFeel;

		public RTSceneGizmoCamera SceneGizmoCamera => null;

		public Gizmo OwnerGizmo => null;

		public Camera SceneCamera => null;

		public SceneGizmoLookAndFeel LookAndFeel => null;

		public SceneGizmoLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void OnAttached()
		{
		}

		public override void OnGUI()
		{
		}

		public override void OnGizmoRender(Camera camera)
		{
		}
	}
}
