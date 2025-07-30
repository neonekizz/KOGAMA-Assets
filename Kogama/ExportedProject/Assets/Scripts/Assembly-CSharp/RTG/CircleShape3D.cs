using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class CircleShape3D : Shape3D
	{
		private Vector3 _center;

		private float _radius;

		private Quaternion _rotation;

		private CircleEpsilon _epsilon;

		private Shape3DRaycastMode _raycastMode;

		public Vector3 Center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public Vector3 Normal => default(Vector3);

		public CircleEpsilon Epsilon
		{
			get
			{
				return default(CircleEpsilon);
			}
			set
			{
			}
		}

		public float RadiusEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ExtrudeEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float WireEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Shape3DRaycastMode RaycastMode
		{
			get
			{
				return default(Shape3DRaycastMode);
			}
			set
			{
			}
		}

		public static Vector3 ModelRight => default(Vector3);

		public static Vector3 ModelUp => default(Vector3);

		public static Vector3 ModelLook => default(Vector3);

		public static Vector3 ModelCenter => default(Vector3);

		public static Vector3 ModelNormal => default(Vector3);

		public void AlignNormal(Vector3 axis)
		{
		}

		public void AlignRight(Vector3 axis)
		{
		}

		public void AlignUp(Vector3 axis)
		{
		}

		public override void RenderSolid()
		{
		}

		public override void RenderWire()
		{
		}

		public override bool Raycast(Ray ray, out float t)
		{
			t = default(float);
			return false;
		}

		public override bool RaycastWire(Ray ray, out float t)
		{
			t = default(float);
			return false;
		}

		public bool ContainsPoint(Vector3 point, bool checkOnPlane)
		{
			return false;
		}

		public List<Vector3> GetExtentPoints()
		{
			return null;
		}

		public override AABB GetAABB()
		{
			return default(AABB);
		}
	}
}
