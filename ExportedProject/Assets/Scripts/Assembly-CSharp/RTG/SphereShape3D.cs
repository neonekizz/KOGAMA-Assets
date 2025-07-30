using UnityEngine;

namespace RTG
{
	public class SphereShape3D : Shape3D
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

			private int _numDetailSliceRings;

			private float _radiusAdd;

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

			public int NumDetailSliceRings
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public float RadiusAdd
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

		private float _radius;

		private Vector3 _center;

		private Quaternion _rotation;

		private SphereEpsilon _epsilon;

		private WireRenderDescriptor _wireRenderDesc;

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

		public float WireRadius => 0f;

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

		public SphereEpsilon Epsilon
		{
			get
			{
				return default(SphereEpsilon);
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

		public WireRenderDescriptor WireRenderDesc => null;

		public Vector3 CentralAxis => default(Vector3);

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public static Vector3 ModelRight => default(Vector3);

		public static Vector3 ModelUp => default(Vector3);

		public static Vector3 ModelLook => default(Vector3);

		public static Vector3 ModelCenter => default(Vector3);

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

		public override AABB GetAABB()
		{
			return default(AABB);
		}
	}
}
