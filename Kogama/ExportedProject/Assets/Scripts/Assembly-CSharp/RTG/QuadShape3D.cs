using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class QuadShape3D : Shape3D
	{
		[Flags]
		public enum WireEdgeFlags
		{
			None = 0,
			Top = 1,
			Right = 2,
			Bottom = 4,
			Left = 8,
			All = 0xF
		}

		public class WireRenderDescriptor
		{
			private WireEdgeFlags _wireEdgeFlags;

			public WireEdgeFlags WireEdgeFlags
			{
				get
				{
					return default(WireEdgeFlags);
				}
				set
				{
				}
			}
		}

		private Shape3DRaycastMode _raycastMode;

		private Vector3 _center;

		private Vector2 _size;

		private Quaternion _rotation;

		private QuadEpsilon _epsilon;

		private WireRenderDescriptor _wireRenderDesc;

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

		public Vector2 Size
		{
			get
			{
				return default(Vector2);
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

		public QuadEpsilon Epsilon
		{
			get
			{
				return default(QuadEpsilon);
			}
			set
			{
			}
		}

		public Vector2 SizeEps
		{
			get
			{
				return default(Vector2);
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

		public WireRenderDescriptor WireRenderDesc => null;

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

		public List<Vector3> GetCornerPoints()
		{
			return null;
		}

		public Vector3 GetCornerPosition(QuadCorner quadCorner)
		{
			return default(Vector3);
		}

		public void SetCornerPointPosition(QuadCorner quadCorner, Vector3 position)
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

		public List<Vector3> GetCorners()
		{
			return null;
		}

		public override AABB GetAABB()
		{
			return default(AABB);
		}
	}
}
