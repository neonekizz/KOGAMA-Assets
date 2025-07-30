using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class TorusShape3D : Shape3D
	{
		public enum WireRenderFlags
		{
			None = 0,
			TubeSlices = 1,
			AxialSlices = 2,
			All = 3
		}

		public class WireRenderDescriptor
		{
			private WireRenderFlags _wireFlags;

			private int _numTubeSlices;

			private int _numAxialSlices;

			public int NumTubeSlices
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int NumAxialSlices
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public WireRenderFlags WireFlags
			{
				get
				{
					return default(WireRenderFlags);
				}
				set
				{
				}
			}
		}

		private float _coreRadius;

		private float _tubeRadius;

		private Vector3 _center;

		private Quaternion _rotation;

		private TorusEpsilon _epsilon;

		private WireRenderDescriptor _wireRenderDesc;

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

		public float TubeRadius
		{
			get
			{
				return 0f;
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

		public float TubeRadiusEps
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
