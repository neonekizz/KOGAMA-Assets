using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class RightAngTriangle3D : Shape3D
	{
		private Vector3 _rightAngleCorner;

		private float _XLength;

		private float _YLength;

		private AxisSign _XLengthSign;

		private AxisSign _YLengthSign;

		private Quaternion _rotation;

		private TriangleEpsilon _epsilon;

		private Shape3DRaycastMode _raycastMode;

		public Vector3 RightAngleCorner
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float XLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float YLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RealXLength => 0f;

		public float RealYLength => 0f;

		public AxisSign XLengthSign
		{
			get
			{
				return default(AxisSign);
			}
			set
			{
			}
		}

		public AxisSign YLengthSign
		{
			get
			{
				return default(AxisSign);
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

		public Plane Plane => default(Plane);

		public TriangleEpsilon Epsilon
		{
			get
			{
				return default(TriangleEpsilon);
			}
			set
			{
			}
		}

		public float AreaEps
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

		public static Vector3 ModelRightAngleCorner => default(Vector3);

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

		public override void RenderSolid()
		{
		}

		public override void RenderWire()
		{
		}

		public List<Vector3> GetPoints()
		{
			return null;
		}

		public override AABB GetAABB()
		{
			return default(AABB);
		}

		public bool ContainsPoint(Vector3 point, bool checkOnPlane)
		{
			return false;
		}
	}
}
