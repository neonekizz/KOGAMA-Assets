using UnityEngine;

namespace RTG
{
	public abstract class Shape3D
	{
		public bool Raycast(Ray ray)
		{
			return false;
		}

		public bool RaycastWire(Ray ray)
		{
			return false;
		}

		public virtual bool RaycastWire(Ray ray, out float t)
		{
			t = default(float);
			return false;
		}

		public abstract void RenderSolid();

		public abstract void RenderWire();

		public abstract bool Raycast(Ray ray, out float t);

		public abstract AABB GetAABB();
	}
}
