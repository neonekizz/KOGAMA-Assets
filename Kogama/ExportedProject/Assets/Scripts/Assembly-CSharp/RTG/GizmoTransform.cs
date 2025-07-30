using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	public class GizmoTransform
	{
		public enum ChangeReason
		{
			TRSChange = 0,
			ParentChange = 1
		}

		public struct ChangeData
		{
			public ChangeReason ChangeReason;

			public GizmoDimension TRSDimension;

			public ChangeData(ChangeReason changeReason, GizmoDimension trsDimension)
			{
				ChangeReason = default(ChangeReason);
				TRSDimension = default(GizmoDimension);
			}
		}

		private bool _firingChanged3DEvent;

		private bool _firingChanged2DEvent;

		private Vector3 _position3D;

		private Vector3 _localPosition3D;

		private Quaternion _rotation3D;

		private Quaternion _localRotation3D;

		private Vector2 _position2D;

		private Vector2 _localPosition2D;

		private float _rotation2DDegrees;

		private Quaternion _rotation2D;

		private float _localRotation2DDegrees;

		private Quaternion _localRotation2D;

		private Vector3[] _axes3D;

		private Vector2[] _axes2D;

		private GizmoTransform _parent;

		private List<GizmoTransform> _children;

		public bool CanChange3D => false;

		public bool CanChange2D => false;

		public GizmoTransform Parent => null;

		public int NumChildren => 0;

		public List<GizmoTransform> Children => null;

		public Vector3 Right3D => default(Vector3);

		public Vector3 Up3D => default(Vector3);

		public Vector3 Look3D => default(Vector3);

		public Vector2 Right2D => default(Vector2);

		public Vector2 Up2D => default(Vector2);

		public Vector3 Position3D
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector2 Position2D
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Quaternion Rotation3D
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Quaternion Rotation2D => default(Quaternion);

		public float Rotation2DDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 LocalPosition3D
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector2 LocalPosition2D
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Quaternion LocalRotation3D
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Quaternion LocalRotation2D => default(Quaternion);

		public float LocalRotation2DDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public event GizmoEntityTransformChangedHandler Changed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static List<GizmoTransform> FilterParentsOnly(IEnumerable<GizmoTransform> transforms)
		{
			return null;
		}

		public PlaneQuadrantId Get3DQuadrantFacingCamera(PlaneId planeId, Camera camera)
		{
			return default(PlaneQuadrantId);
		}

		public void Rotate3D(Quaternion rotation)
		{
		}

		public void Rotate2D(float rotation)
		{
		}

		public void Rotate2D(Quaternion rotation)
		{
		}

		public Vector3 TransformVector3D(Vector3 vec)
		{
			return default(Vector3);
		}

		public Vector2 TransformVector2D(Vector2 vec)
		{
			return default(Vector2);
		}

		public Vector3 TransformNormal3D(Vector3 normal)
		{
			return default(Vector3);
		}

		public Vector2 TransformNormal2D(Vector2 normal)
		{
			return default(Vector2);
		}

		public Vector3 InverseTransformNormal3D(Vector3 normal)
		{
			return default(Vector3);
		}

		public Vector2 InverseTransformNormal2D(Vector2 normal)
		{
			return default(Vector2);
		}

		public Vector3 TransformPoint3D(Vector3 point)
		{
			return default(Vector3);
		}

		public Vector2 TransformPoint2D(Vector2 point)
		{
			return default(Vector2);
		}

		public Vector3 InverseTransformPoint3D(Vector3 point)
		{
			return default(Vector3);
		}

		public Vector2 InverseTransformPoint2D(Vector2 point)
		{
			return default(Vector2);
		}

		public void AlignAxis3D(int axisIndex, AxisSign axisSign, Vector3 axis)
		{
		}

		public void AlignAxis2D(int axisIndex, AxisSign axisSign, Vector2 axis)
		{
		}

		public bool IsChildOf(GizmoTransform transform)
		{
			return false;
		}

		public void SetParent(GizmoTransform newParent)
		{
		}

		public Vector3 GetAxis3D(AxisDescriptor axisDesc)
		{
			return default(Vector3);
		}

		public Vector3 GetAxis3D(int axisIndex, AxisSign axisSign)
		{
			return default(Vector3);
		}

		public Vector2 GetAxis2D(AxisDescriptor axisDesc)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2D(int axisIndex, AxisSign axisSign)
		{
			return default(Vector2);
		}

		public Vector3[] GetAxes3D()
		{
			return null;
		}

		public Vector2[] GetAxes2D()
		{
			return null;
		}

		public Plane GetPlane3D(PlaneId planeId, PlaneQuadrantId planeQuadrantId)
		{
			return default(Plane);
		}

		public Plane GetPlane3D(PlaneDescriptor planeDesc)
		{
			return default(Plane);
		}

		private void ChangePosition3D(Vector3 position)
		{
		}

		private void ChangePosition2D(Vector2 position)
		{
		}

		private void ChangeRotation3D(Quaternion rotation)
		{
		}

		private void ChangeRotation2D(float rotation)
		{
		}

		private void ChangeRotation2D(Quaternion rotation)
		{
		}

		private void ChangeLocalPosition3D(Vector3 localPosition)
		{
		}

		private void ChangeLocalPosition2D(Vector2 localPosition)
		{
		}

		private void ChangeLocalRotation3D(Quaternion localRotation)
		{
		}

		private void ChangeLocalRotation2D(float localRotation)
		{
		}

		private void ChangeLocalRotation2D(Quaternion localRotation)
		{
		}

		private void OnParentChanged()
		{
		}

		private void OnPosition3DChanged()
		{
		}

		private void OnPosition2DChanged()
		{
		}

		private void OnLocalPosition3DChanged()
		{
		}

		private void OnLocalPosition2DChanged()
		{
		}

		private void OnRotation3DChanged()
		{
		}

		private void OnRotation2DChanged()
		{
		}

		private void OnLocalRotation3DChanged()
		{
		}

		private void OnLocalRotation2DChanged()
		{
		}

		private void UpdateChildTransforms3D()
		{
		}

		private void UpdateChildTransforms2D()
		{
		}

		private void OnChanged(ChangeData changeData)
		{
		}

		private void Update3DAxes()
		{
		}

		private void Update2DAxes()
		{
		}
	}
}
