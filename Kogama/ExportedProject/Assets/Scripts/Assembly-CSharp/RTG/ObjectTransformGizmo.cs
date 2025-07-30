using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class ObjectTransformGizmo : GizmoBehaviour
	{
		public class ObjectRestrictions
		{
			private bool[] _moveAxesMask;

			private bool[] _scaleAxesMask;

			private HashSet<int> _handleMask;

			public bool CanMoveAlongAllAxes()
			{
				return false;
			}

			public bool CanScaleAlongAllAxes()
			{
				return false;
			}

			public bool CanMoveAlongAxis(int axisIndex)
			{
				return false;
			}

			public bool CanScaleAlongAxis(int axisIndex)
			{
				return false;
			}

			public void SetCanMoveAlongAxis(int axisIndex, bool canMove)
			{
			}

			public void SetCanScaleAlongAxis(int axisIndex, bool canScale)
			{
			}

			public bool IsAffectedByHandle(int handleId)
			{
				return false;
			}

			public void SetIsAffectedByHandle(int handleId, bool isAffected)
			{
			}

			public Vector3 AdjustMoveVector(Vector3 moveVector)
			{
				return default(Vector3);
			}

			public Vector3 AdjustScaleVector(Vector3 scaleVector)
			{
				return default(Vector3);
			}
		}

		[Flags]
		public enum Channels
		{
			None = 0,
			Position = 1,
			Rotation = 2,
			Scale = 4,
			All = 7
		}

		private enum TargetObjectMode
		{
			Multiple = 0,
			Single = 1
		}

		private TargetObjectMode _targetObjectMode;

		private Channels _transformChannelFlags;

		private IEnumerable<GameObject> _targetObjects;

		private GameObject _targetPivotObject;

		private List<LocalTransformSnapshot> _preTransformSnapshots;

		private List<GameObject> _transformableParents;

		private AABB _targetGroupAABBOnDragBegin;

		private GizmoSpace _transformSpace;

		private bool _isTransformSpacePermanent;

		private GizmoObjectTransformPivot _transformPivot;

		private bool _isTransformPivotPermanent;

		private bool _scaleConstraintEnabled;

		private Vector3 _minPositiveScale;

		private Vector3 _customWorldPivot;

		private Dictionary<GameObject, Vector3> _objectToCustomLocalPivot;

		private Dictionary<GameObject, ObjectRestrictions> _objectToRestrictions;

		[SerializeField]
		private ObjectTransformGizmoSettings _settings;

		private ObjectTransformGizmoSettings _sharedSettings;

		public GizmoObjectTransformPivot TransformPivot => default(GizmoObjectTransformPivot);

		public bool IsTransformPivotPermanent => false;

		public GizmoSpace TransformSpace => default(GizmoSpace);

		public bool IsTransformSpacePermanent => false;

		public Channels TransformChannelFlags => default(Channels);

		public bool CanAffectPosition => false;

		public bool CanAffectRotation => false;

		public bool CanAffectScale => false;

		public Vector3 CustomWorldPivot => default(Vector3);

		public bool ScaleConstraintEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3 MinPositiveScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public ObjectTransformGizmoSettings Settings => null;

		public ObjectTransformGizmoSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void OnAttached()
		{
		}

		public override void OnDetached()
		{
		}

		public void MakeTransformSpacePermanent()
		{
		}

		public void MakeTransformPivotPermanent()
		{
		}

		public bool ContainsRestrictionsForObject(GameObject targetObject)
		{
			return false;
		}

		public void RegisterObjectRestrictions(GameObject targetObject, ObjectRestrictions restrictions)
		{
		}

		public void RegisterObjectRestrictions(List<GameObject> targetObjects, ObjectRestrictions restrictions)
		{
		}

		public void UnregisterObjectRestrictions(GameObject targetObject)
		{
		}

		public ObjectRestrictions GetObjectRestrictions(GameObject targetObject)
		{
			return null;
		}

		public void SetTransformChannelFlags(Channels flags)
		{
		}

		public void SetCanAffectPosition(bool affectPosition)
		{
		}

		public void SetCanAffectRotation(bool affectRotation)
		{
		}

		public void SetCanAffectScale(bool affectScale)
		{
		}

		public void SetTargetPivotObject(GameObject targetPivotObject)
		{
		}

		public void SetTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		public void SetTargetObject(GameObject targetObject)
		{
		}

		public void SetTransformPivot(GizmoObjectTransformPivot transformPivot)
		{
		}

		public void SetCustomWorldPivot(Vector3 pivot)
		{
		}

		public void SetObjectCustomLocalPivot(GameObject gameObj, Vector3 pivot)
		{
		}

		public Vector3 GetObjectCustomLocalPivot(GameObject gameObj)
		{
			return default(Vector3);
		}

		public void SetTransformSpace(GizmoSpace transformSpace)
		{
		}

		public AABB GetTargetObjectGroupWorldAABB()
		{
			return default(AABB);
		}

		public int GetNumTransformableParentObjects()
		{
			return 0;
		}

		public void RefreshPosition()
		{
		}

		public void RefreshRotation()
		{
		}

		public void RefreshPositionAndRotation()
		{
		}

		public override void OnGizmoDragBegin(int handleId)
		{
		}

		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		public override void OnGizmoDragEnd(int handleId)
		{
		}

		private List<GameObject> GetTransformableParentObjects()
		{
			return null;
		}

		private void OnUndoRedoEnd(IUndoRedoAction action)
		{
		}

		private void MoveObjects(Vector3 moveVector)
		{
		}

		private void MoveObject(GameObject gameObject, Vector3 moveVector)
		{
		}

		private void RotateObjects(Quaternion rotation)
		{
		}

		private void RotateObject(GameObject gameObject, Quaternion rotation, Vector3 rotationPivot)
		{
		}

		private void ScaleObjects()
		{
		}

		private void ScaleObject(GameObject gameObject, Vector3 scalePivot)
		{
		}

		private ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			return default(ObjectBounds.QueryConfig);
		}
	}
}
