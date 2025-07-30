using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class SceneSettings : Settings
	{
		[SerializeField]
		private ScenePhysicsMode _physicsMode;

		public ScenePhysicsMode PhysicsMode
		{
			get
			{
				return default(ScenePhysicsMode);
			}
			set
			{
			}
		}
	}
}
