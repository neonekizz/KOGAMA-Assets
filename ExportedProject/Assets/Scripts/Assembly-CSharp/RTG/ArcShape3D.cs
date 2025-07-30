using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class ArcShape3D : Shape3D
	{
		public enum WireRenderFlags
		{
			None = 0,
			ExtremitiesBorder = 1,
			ArcBorder = 2,
			All = 3
		}

		public class WireRenderDescriptor
		{
			private WireRenderFlags _wireFlags;

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

		private WireRenderDescriptor _wireRenderDesc;

		private Vector3 _startPoint;

		private Vector3 _endPoint;

		private Vector3 _origin;

		private Plane _plane;

		private float _radius;

		private AABB _aabb;

		private float _degreeAngleFromStart;

		private bool _forceShortestArc;

		private List<Vector3> _borderPoints;

		private int _numBorderPoints;

		private bool _areBorderPointsDirty;

		private ArcEpsilon _epsilon;

		private Shape3DRaycastMode _raycastMode;

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

		public bool ForceShortestArc
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float DegreeAngleFromStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AbsDegreeAngleFromStart => 0f;

		public int NumBorderPoints
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vector3 Origin
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 StartPoint => default(Vector3);

		public Vector3 EndPoint => default(Vector3);

		public Plane Plane => default(Plane);

		public Vector3 Normal => default(Vector3);

		public ArcEpsilon Epsilon
		{
			get
			{
				return default(ArcEpsilon);
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

		public WireRenderDescriptor WireRenderDesc => null;

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

		public override void RenderSolid()
		{
		}

		public override void RenderWire()
		{
		}

		public void SetArcData(Plane plane, Vector3 origin, Vector3 startPoint, float radius)
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

		public override AABB GetAABB()
		{
			return default(AABB);
		}

		private void OnBorderPointsFoundDirty()
		{
		}

		private void CalculateEndPoint()
		{
		}
	}
}
