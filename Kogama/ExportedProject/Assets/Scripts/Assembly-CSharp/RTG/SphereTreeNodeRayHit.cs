using UnityEngine;

namespace RTG
{
	public class SphereTreeNodeRayHit<T>
	{
		private SphereTreeNode<T> _hitNode;

		private Vector3 _hitPoint;

		private float _hitEnter;

		public SphereTreeNode<T> HitNode => null;

		public Vector3 HitPoint => default(Vector3);

		public float HitEnter => 0f;

		public SphereTreeNodeRayHit(Ray ray, SphereTreeNode<T> hitNode, float hitEnter)
		{
		}
	}
}
