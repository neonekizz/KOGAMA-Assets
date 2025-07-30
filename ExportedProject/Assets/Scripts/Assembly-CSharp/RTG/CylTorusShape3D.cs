using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class CylTorusShape3D : Shape3D
	{
		private float _coreRadius;

		private float _hrzRadius;

		private float _vertRadius;

		private Vector3 _center;

		private Quaternion _rotation;

		private TorusEpsilon _epsilon;

		public float CoreRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float HrzRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float VertRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 Bottom
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Top
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

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

		public TorusEpsilon Epsilon
		{
			get
			{
				return default(TorusEpsilon);
			}
			set
			{
			}
		}

		public float CylHrzRadiusEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CylVertRadiusEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static Vector3 ModelRight => default(Vector3);

		public static Vector3 ModelUp => default(Vector3);

		public static Vector3 ModelLook => default(Vector3);

		public static Vector3 ModelCenter => default(Vector3);

		public override bool Raycast(Ray ray, out float t)
		{
			t = default(float);
			return false;
		}

		public override void RenderSolid()
		{
		}

		public override void RenderWire()
		{
		}

		public List<Vector3> GetHrzExtents()
		{
			return null;
		}

		public override AABB GetAABB()
		{
			return default(AABB);
		}
	}
}
