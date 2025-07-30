using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class ConeShape3D : Shape3D
	{
		public enum WireRenderMode
		{
			Basic = 0,
			Detailed = 1
		}

		public class WireRenderDescriptor
		{
			private WireRenderMode _wireMode;

			private int _numDetailAxialRings;

			private int _numDetailAxialSegments;

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

			public int NumDetailAxialRings
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int NumDetailAxialSegments
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}
		}

		private WireRenderDescriptor _wireRenderDesc;

		private Vector3 _baseCenter;

		private Quaternion _rotation;

		private float _baseRadius;

		private float _height;

		private ConeEpsilon _epsilon;

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

		public float BaseRadius
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

		public Vector3 CentralAxis => default(Vector3);

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public ConeEpsilon Epsilon
		{
			get
			{
				return default(ConeEpsilon);
			}
			set
			{
			}
		}

		public float HrzEps
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

		public WireRenderDescriptor WireRenderDesc => null;

		public static Vector3 ModelRight => default(Vector3);

		public static Vector3 ModelUp => default(Vector3);

		public static Vector3 ModelLook => default(Vector3);

		public static Vector3 ModelBaseCenter => default(Vector3);

		public void AlignTip(Vector3 axis)
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

		public List<Vector3> GetBaseExtents()
		{
			return null;
		}

		public override AABB GetAABB()
		{
			return default(AABB);
		}
	}
}
