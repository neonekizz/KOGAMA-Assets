using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GameObjectRayHit
	{
		private GameObject _hitObject;

		private Vector3 _hitPoint;

		private float _hitEnter;

		private Vector3 _hitNormal;

		private Plane _hitPlane;

		private MeshRayHit _meshRayHit;

		public GameObject HitObject => null;

		public Vector3 HitPoint => default(Vector3);

		public float HitEnter => 0f;

		public Vector3 HitNormal => default(Vector3);

		public Plane HitPlane => default(Plane);

		public MeshRayHit MeshRayHit => null;

		public static void SortByHitDistance(List<GameObjectRayHit> hits)
		{
		}

		public static void Store(Ray hitRay, IEnumerable<RaycastHit2D> hits2D, IEnumerable<RaycastHit> hits3D, List<GameObjectRayHit> hits)
		{
		}

		public GameObjectRayHit(Ray hitRay, RaycastHit hit3D)
		{
		}

		public GameObjectRayHit(Ray hitRay, RaycastHit2D hit2D)
		{
		}

		public GameObjectRayHit(Ray hitRay, GameObject hitObject, Vector3 hitNormal, float hitEnter)
		{
		}

		public GameObjectRayHit(Ray ray, GameObject hitObject, MeshRayHit meshRayHit)
		{
		}
	}
}
