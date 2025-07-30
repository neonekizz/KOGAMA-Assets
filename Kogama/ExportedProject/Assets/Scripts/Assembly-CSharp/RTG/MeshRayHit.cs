using UnityEngine;

namespace RTG
{
	public class MeshRayHit
	{
		private int _hitTriangleIndex;

		private Vector3 _hitPoint;

		private float _hitEnter;

		private Vector3 _hitNormal;

		public int HitTriangleIndex => 0;

		public Vector3 HitPoint => default(Vector3);

		public float HitEnter => 0f;

		public Vector3 HitNormal => default(Vector3);

		public MeshRayHit(Ray ray, int hitTriangleIndex, float hitEnter, Vector3 hitNormal)
		{
		}
	}
}
