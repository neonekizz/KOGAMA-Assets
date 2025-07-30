using UnityEngine;

namespace RTG
{
	public class BoxShape3D : Shape3D
	{
		public enum WireRenderMode
		{
			Wire = 0,
			WireCorners = 1
		}

		public class WireRenderDescriptor
		{
			private float _cornerLinePercentage;

			private WireRenderMode _wireMode;

			public WireRenderMode WireMode
			{
				get
				{
					return default(WireRenderMode);
				}
				set
				{
				}
			}

			public float CornerLinePercentage
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}
		}

		private WireRenderDescriptor _wireRenderDesc;

		private Vector3 _size;

		private Vector3 _center;

		private Quaternion _rotation;

		private BoxEpsilon _epsilon;

		public Vector3 Size
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

		public Vector3 Extents => default(Vector3);

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

		public BoxEpsilon Epsilon
		{
			get
			{
				return default(BoxEpsilon);
			}
			set
			{
			}
		}

		public Vector3 SizeEps
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float WidthEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float HeightEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float DepthEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 Min
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Max
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

		public WireRenderDescriptor WireRenderDesc => null;

		public static Vector3 ModelRight => default(Vector3);

		public static Vector3 ModelUp => default(Vector3);

		public static Vector3 ModelLook => default(Vector3);

		public static Vector3 ModelCenter => default(Vector3);

		public void FromOBB(OBB obb)
		{
		}

		public float GetSizeAlongDirection(Vector3 direction)
		{
			return 0f;
		}

		public void AlignWidth(Vector3 axis)
		{
		}

		public void AlignHeight(Vector3 axis)
		{
		}

		public void AlignDepth(Vector3 axis)
		{
		}

		public Vector3 GetFaceCenter(BoxFace boxFace)
		{
			return default(Vector3);
		}

		public void SetFaceCenter(BoxFace boxFace, Vector3 newCenter)
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

		public override AABB GetAABB()
		{
			return default(AABB);
		}

		public OBB GetOBB()
		{
			return default(OBB);
		}

		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}
	}
}
