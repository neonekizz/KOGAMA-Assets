using UnityEngine;

namespace RTG
{
	public class XZGridRayHit
	{
		private XZGridCell _hitCell;

		private Vector3 _hitPoint;

		private float _hitEnter;

		private Vector3 _hitNormal;

		private Plane _hitPlane;

		public XZGridCell HitCell => null;

		public Vector3 HitPoint => default(Vector3);

		public float HitEnter => 0f;

		public Vector3 HitNormal => default(Vector3);

		public Plane HitPlane => default(Plane);

		public XZGridRayHit(Ray ray, XZGridCell hitCell, float hitEnter)
		{
		}
	}
}
