using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class CylinderShape3D : Shape3D
	{
		private Vector3 _baseCenter;

		private float _radius;

		private float _height;

		private Quaternion _rotation;

		private CylinderEpsilon _epsilon;

		public Vector3 BaseCenter
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 TopCenter
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

		public float Height
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

		public CylinderEpsilon Epsilon
		{
			get
			{
				return default(CylinderEpsilon);
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

		public float VertEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 CentralAxis => default(Vector3);

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public static Vector3 ModelRight => default(Vector3);

		public static Vector3 ModelUp => default(Vector3);

		public static Vector3 ModelLook => default(Vector3);

		public static Vector3 ModelBaseCenter => default(Vector3);

		public void AlignCentralAxis(Vector3 axis)
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

		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		public List<Vector3> GetBottomCapExtentPoints()
		{
			return null;
		}

		public List<Vector3> GetTopCapExtentPoints()
		{
			return null;
		}

		public AABB GetModelAABB()
		{
			return default(AABB);
		}

		public override AABB GetAABB()
		{
			return default(AABB);
		}
	}
}
