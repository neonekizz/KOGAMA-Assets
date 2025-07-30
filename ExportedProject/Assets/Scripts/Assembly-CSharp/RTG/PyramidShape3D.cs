using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class PyramidShape3D : Shape3D
	{
		private Vector3 _baseCenter;

		private float _baseWidth;

		private float _baseDepth;

		private float _height;

		private Quaternion _rotation;

		private PyramidEpsilon _epsilon;

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

		public Vector3 Tip
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

		public float BaseWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BaseDepth
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

		public PyramidEpsilon Epsilon
		{
			get
			{
				return default(PyramidEpsilon);
			}
			set
			{
			}
		}

		public float PtContainEps
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

		public void PointTipAlongAxis(Vector3 axis)
		{
		}

		public override void RenderSolid()
		{
		}

		public override void RenderWire()
		{
		}

		public List<Vector3> GetBaseCornerPoints()
		{
			return null;
		}

		public override AABB GetAABB()
		{
			return default(AABB);
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
	}
}
