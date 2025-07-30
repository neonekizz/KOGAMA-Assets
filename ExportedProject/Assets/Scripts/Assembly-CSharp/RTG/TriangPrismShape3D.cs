using UnityEngine;

namespace RTG
{
	public class TriangPrismShape3D : Shape3D
	{
		private Vector3 _baseCenter;

		private float _width;

		private float _height;

		private float _depth;

		private Quaternion _rotation;

		private PrismEpsilon _epsilon;

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

		public Vector3 FrontCenter
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

		public Vector3 MidTip
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Width
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

		public float Depth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public PrismEpsilon Epsilon
		{
			get
			{
				return default(PrismEpsilon);
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

		public Vector3 CentralAxis => default(Vector3);

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public static Vector3 ModelRight => default(Vector3);

		public static Vector3 ModelUp => default(Vector3);

		public static Vector3 ModelLook => default(Vector3);

		public static Vector3 ModelBaseCenter => default(Vector3);

		public void AlignWidth(Vector3 axis)
		{
		}

		public void AlignHeight(Vector3 axis)
		{
		}

		public void AlignDepth(Vector3 axis)
		{
		}

		public override void RenderSolid()
		{
		}

		public override void RenderWire()
		{
		}

		public void MakeEquilateral(float sideLength)
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

		public override AABB GetAABB()
		{
			return default(AABB);
		}
	}
}
