using UnityEngine;

namespace RTG
{
	public class EqTriangle3D : Shape3D
	{
		private float _sideLength;

		private Quaternion _rotation;

		private TriangleEpsilon _epsilon;

		private Vector3[] _points;

		private Vector3 _centroid;

		private bool _arePointsDirty;

		public float SideLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 Centroid
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Altitude => 0f;

		public float CentroidAltitude => 0f;

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

		public Vector3 Normal => default(Vector3);

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public static Vector3 ModelRight => default(Vector3);

		public static Vector3 ModelUp => default(Vector3);

		public static Vector3 ModelLook => default(Vector3);

		public static Vector3 ModelCentroid => default(Vector3);

		public void AlignNormal(Vector3 axis)
		{
		}

		public void AlignRight(Vector3 axis)
		{
		}

		public void AlignUp(Vector3 axis)
		{
		}

		public Vector3 GetPoint(EqTrianglePoint point)
		{
			return default(Vector3);
		}

		public void SetPoint(EqTrianglePoint point, Vector3 pointValue)
		{
		}

		public Vector3 GetEdgeMidPoint(EqTriangleEdge edge)
		{
			return default(Vector3);
		}

		public Vector3 GetEdge(EqTriangleEdge edge)
		{
			return default(Vector3);
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

		public override AABB GetAABB()
		{
			return default(AABB);
		}

		private void OnPointsFoundDirty()
		{
		}
	}
}
