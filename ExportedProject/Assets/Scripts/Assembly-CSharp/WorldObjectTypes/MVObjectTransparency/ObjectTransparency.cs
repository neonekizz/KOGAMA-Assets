using UnityEngine;

namespace WorldObjectTypes.MVObjectTransparency
{
	public class ObjectTransparency : MonoBehaviour
	{
		public MVObjectTransparency woObjectTransparency;

		private float currentAlpha;

		public bool IsDrawingEnabled { get; set; }

		public float Transparency { get; set; }

		public void Initialize()
		{
		}
	}
}
