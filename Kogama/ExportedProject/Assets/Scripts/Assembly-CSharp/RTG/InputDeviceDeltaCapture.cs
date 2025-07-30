using UnityEngine;

namespace RTG
{
	public class InputDeviceDeltaCapture
	{
		private int _id;

		private Vector3 _origin;

		private Vector3 _delta;

		public int Id => 0;

		public Vector3 Origin => default(Vector3);

		public Vector3 Delta => default(Vector3);

		public InputDeviceDeltaCapture(int id, Vector3 origin)
		{
		}

		public void Update(Vector3 devicePosition)
		{
		}
	}
}
