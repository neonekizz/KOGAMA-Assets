using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class Gizmo
	{
		private bool _isEnabled;

		private bool _forceRefresh;

		private GizmoHandleCollection _handles;

		private GizmoBehaviourCollection _behaviours;

		private GizmoHoverInfo _hoverInfo;

		private GizmoDragInfo _dragInfo;

		private IGizmoHandle _hoveredHandle;

		private Priority _genericHoverPriority;

		private Priority _hoverPriority3D;

		private Priority _hoverPriority2D;

		private IGizmoDragSession _activeDragSession;

		private GizmoTransform _transform;

		[NonSerialized]
		private MoveGizmo _moveGizmo;

		[NonSerialized]
		private RotationGizmo _rotationGizmo;

		[NonSerialized]
		private ScaleGizmo _scaleGizmo;

		[NonSerialized]
		private UniversalGizmo _universalGizmo;

		[NonSerialized]
		private ObjectTransformGizmo _objectTransformGizmo;

		[NonSerialized]
		private SceneGizmo _sceneGizmo;

		public static int InputDeviceDragButtonIndex => 0;

		public int NumHandles => 0;

		public Camera FocusCamera => null;

		public bool IsEnabled => false;

		public bool ForceRefresh => false;

		public Priority GenericHoverPriority => null;

		public Priority HoverPriority3D => null;

		public Priority HoverPriority2D => null;

		public GizmoTransform Transform => null;

		public GizmoHoverInfo HoverInfo => default(GizmoHoverInfo);

		public bool IsHovered => false;

		public int HoverHandleId => 0;

		public GizmoDimension HoverHandleDimension => default(GizmoDimension);

		public Vector3 HoverPoint => default(Vector3);

		public GizmoDragInfo DragInfo => default(GizmoDragInfo);

		public bool IsDragged => false;

		public GizmoDragChannel ActiveDragChannel => default(GizmoDragChannel);

		public int DragHandleId => 0;

		public Vector3 DragBeginPoint => default(Vector3);

		public GizmoDimension DragHandleDimension => default(GizmoDimension);

		public Vector3 TotalDragOffset => default(Vector3);

		public Quaternion TotalDragRotation => default(Quaternion);

		public Vector3 TotalDragScale => default(Vector3);

		public Vector3 RelativeDragOffset => default(Vector3);

		public Quaternion RelativeDragRotation => default(Quaternion);

		public Vector3 RelativeDragScale => default(Vector3);

		public MoveGizmo MoveGizmo => null;

		public RotationGizmo RotationGizmo => null;

		public ScaleGizmo ScaleGizmo => null;

		public UniversalGizmo UniversalGizmo => null;

		public ObjectTransformGizmo ObjectTransformGizmo => null;

		public SceneGizmo SceneGizmo => null;

		public event GizmoPostEnabledHandler PostEnabled
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

		public event GizmoPostDisabledHandler PostDisabled
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

		public event GizmoPreUpdateBeginHandler PreUpdateBegin
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

		public event GizmoPostUpdateEndHandler PostUpdateEnd
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

		public event GizmoPreHoverEnterHandler PreHoverEnter
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

		public event GizmoPostHoverEnterHandler PostHoverEnter
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

		public event GizmoPreHoverExitHandler PreHoverExit
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

		public event GizmoPostHoverExitHandler PostHoverExit
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

		public event GizmoPreDragBeginHandler PreDragBegin
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

		public event GizmoPostDragBeginHandler PostDragBegin
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

		public event GizmoPreDragEndHandler PreDragEnd
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

		public event GizmoPostDragEndHandler PostDragEnd
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

		public event GizmoPreDragUpdateHandler PreDragUpdate
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

		public event GizmoPostDragUpdateHandler PostDragUpdate
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

		public event GizmoPreHandlePickedHandler PreHandlePicked
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

		public event GizmoPostHandlePickedHandler PostHandlePicked
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

		public event GizmoPreDragBeginAttemptHandler PreDragBeginAttempt
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

		public event GizmoPostDragBeginAttemptHandler PostDragBeginAttempt
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

		public event GizmoOffsetDragAxisModifyHandler OffsetDragAxisModify
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

		public Camera GetWorkCamera()
		{
			return null;
		}

		public GizmoHandle CreateHandle(int id)
		{
			return null;
		}

		public void SetEnabled(bool enabled)
		{
		}

		public void SetForceRefresh(bool forceRefresh)
		{
		}

		public BehaviourType AddBehaviour<BehaviourType>() where BehaviourType : class, IGizmoBehaviour, new()
		{
			return null;
		}

		public bool AddBehaviour(IGizmoBehaviour behaviour)
		{
			return false;
		}

		public bool RemoveBehaviour(IGizmoBehaviour behaviour)
		{
			return false;
		}

		public List<BehaviourType> GetBehavioursOfType<BehaviourType>() where BehaviourType : class, IGizmoBehaviour
		{
			return null;
		}

		public BehaviourType GetFirstBehaviourOfType<BehaviourType>() where BehaviourType : class, IGizmoBehaviour
		{
			return null;
		}

		public IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType)
		{
			return null;
		}

		public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay)
		{
			return null;
		}

		public IGizmoHandle GetHandleById_SystemCall(int handleId)
		{
			return null;
		}

		public void OnGUI_SystemCall()
		{
		}

		public void OnUpdateBegin_SystemCall()
		{
		}

		public void OnUpdateEnd_SystemCall()
		{
		}

		public void UpdateHandleHoverInfo_SystemCall(GizmoHoverInfo hoverInfo)
		{
		}

		public void Render_SystemCall(Camera camera, Plane[] worldFrustumPlanes)
		{
		}

		public void HandleInputDeviceEvents_SystemCall()
		{
		}

		private void OnInputDevicePickButtonDown()
		{
		}

		private void OnInputDevicePickButtonUp()
		{
		}

		private void EndDragSession()
		{
		}

		private void OnInputDeviceMoved()
		{
		}

		private void TryActivateDragSession()
		{
		}
	}
}
