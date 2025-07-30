using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	public class RTFocusCamera : MonoSingleton<RTFocusCamera>
	{
		private enum MoveDirection
		{
			Left = 0,
			Right = 1,
			Up = 2,
			Down = 3,
			Forward = 4,
			Backwards = 5
		}

		[CompilerGenerated]
		private sealed class _003CDoConstantFocus_003Ed__135 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RTFocusCamera _003C_003E4__this;

			public CameraFocus.Data focusData;

			private float _003CtargetOrthoSize_003E5__2;

			private Vector3 _003CcamMoveDir_003E5__3;

			private float _003CdistanceToTravel_003E5__4;

			private float _003CinitialCamOrthoSize_003E5__5;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoConstantFocus_003Ed__135(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoConstantRotationSwitch_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RTFocusCamera _003C_003E4__this;

			public Quaternion targetRotation;

			private Quaternion _003CsourceRotation_003E5__2;

			private float _003CelapsedTime_003E5__3;

			private Vector3 _003CfocusPt_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoConstantRotationSwitch_003Ed__133(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoSmoothFocus_003Ed__136 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RTFocusCamera _003C_003E4__this;

			public CameraFocus.Data focusData;

			private float _003CtargetOrthoSize_003E5__2;

			private Vector3 _003CcamMoveDir_003E5__3;

			private float _003CelapsedTime_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoSmoothFocus_003Ed__136(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoSmoothLookAround_003Ed__130 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RTFocusCamera _003C_003E4__this;

			public float deviceAxisX;

			public float deviceAxisY;

			private Vector2 _003CrotationAmount_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoSmoothLookAround_003Ed__130(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoSmoothOrbit_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RTFocusCamera _003C_003E4__this;

			public float deviceAxisX;

			public float deviceAxisY;

			private Vector2 _003CrotationAmount_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoSmoothOrbit_003Ed__131(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoSmoothPan_003Ed__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RTFocusCamera _003C_003E4__this;

			public float deviceAxisX;

			public float deviceAxisY;

			private Vector2 _003CpanAmount_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoSmoothPan_003Ed__129(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoSmoothRotationSwitch_003Ed__134 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RTFocusCamera _003C_003E4__this;

			public Quaternion targetRotation;

			private Vector3 _003CfocusPt_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoSmoothRotationSwitch_003Ed__134(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoSmoothZoom_003Ed__132 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RTFocusCamera _003C_003E4__this;

			public float deviceScroll;

			private float _003CzoomAmount_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoSmoothZoom_003Ed__132(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private Camera _targetCamera;

		private Transform _targetTransform;

		[SerializeField]
		private float _fieldOfView;

		private WorldTransformSnapshot _worldTransformSnapshot;

		private CameraPrjSwitchTransition _prjSwitchTranstion;

		private bool _isDoingFocus;

		private IEnumerator _focusCrtn;

		private bool _isDoingRotationSwitch;

		private IEnumerator _genricCamTransformCrtn;

		private bool _isObjectVisibilityDirty;

		private List<GameObject> _visibleObjects;

		private float _focusPointOffset;

		private Vector3 _lastFocusPoint;

		private bool[] _moveDirFlags;

		private float _currentAcceleration;

		[SerializeField]
		private CameraSettings _settings;

		[SerializeField]
		private CameraMoveSettings _moveSettings;

		[SerializeField]
		private CameraPanSettings _panSettings;

		[SerializeField]
		private CameraLookAroundSettings _lookAroundSettings;

		[SerializeField]
		private CameraOrbitSettings _orbitSettings;

		[SerializeField]
		private CameraZoomSettings _zoomSettings;

		[SerializeField]
		private CameraFocusSettings _focusSettings;

		[SerializeField]
		private CameraRotationSwitchSettings _rotationSwitchSettings;

		[SerializeField]
		private CameraProjectionSwitchSettings _projectionSwitchSettings;

		[SerializeField]
		private CameraHotkeys _hotkeys;

		public Camera TargetCamera => null;

		public bool IsDoingProjectionSwitch => false;

		public CameraPrjSwitchTransition.Type PrjSwitchTransitionType => default(CameraPrjSwitchTransition.Type);

		public bool IsDoingRotationSwitch => false;

		public float PrjSwitchProgress => 0f;

		public float PrjSwitchDurationInSeconds => 0f;

		public bool IsDoingFocus => false;

		public Vector3 WorldPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion WorldRotation
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

		public bool IsMovingForward => false;

		public bool IsMovingBackwards => false;

		public bool IsMovingLeft => false;

		public bool IsMovingRight => false;

		public bool IsMovingUp => false;

		public bool IsMovingDown => false;

		public CameraSettings Settings => null;

		public CameraMoveSettings MoveSettings => null;

		public CameraPanSettings PanSettings => null;

		public CameraLookAroundSettings LookAroundSettings => null;

		public CameraOrbitSettings OrbitSettings => null;

		public CameraZoomSettings ZoomSettings => null;

		public CameraFocusSettings FocusSettings => null;

		public CameraRotationSwitchSettings RotationSwitchSettings => null;

		public CameraProjectionSwitchSettings ProjectionSwitchSettings => null;

		public CameraHotkeys Hotkeys => null;

		public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionBegin
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

		public event CameraProjectionSwitchUpdateHandler PrjSwitchTransitionUpdate
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

		public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionEnd
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

		public event CameraCanProcessInputHandler CanProcessInput
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

		public event CameraCanUseScrollWheelHandler CanUseScrollWheel
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

		public bool IsViewportHoveredByDevice()
		{
			return false;
		}

		public void SetTargetCamera(Camera camera)
		{
		}

		public void SetFieldOfView(float fov)
		{
		}

		public void SetObjectVisibilityDirty()
		{
		}

		public void GetVisibleObjects(List<GameObject> visibleObjects)
		{
		}

		public void PerformRotationSwitch(Quaternion targetRotation)
		{
		}

		public void PerformProjectionSwitch()
		{
		}

		public void Focus(List<GameObject> gameObjects)
		{
		}

		public void Focus(AABB focusAABB)
		{
		}

		public void Update_SystemCall()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void HandleMouseAndKeyboardInput()
		{
		}

		private bool CanUseMouseScrollWheel()
		{
			return false;
		}

		private bool CanCameraProcessInput()
		{
			return false;
		}

		private void Zoom(float zoomAmount)
		{
		}

		private Vector3 GetFocusPoint()
		{
			return default(Vector3);
		}

		private float CalculateScrollZoomAmount(float deviceScroll)
		{
			return 0f;
		}

		private void Pan(Vector2 panAmount)
		{
		}

		public void LookAround(float degreesLocalX, float degreesWorldY)
		{
		}

		private void Orbit(float degreesLocalX, float degreesWorldY)
		{
		}

		private void PerformInstantFocus(CameraFocus.Data focusData)
		{
		}

		private void PerformInstantProjectionSwitch()
		{
		}

		private Vector2 CalculateLookAroundRotation(float deviceAxisX, float deviceAxisY)
		{
			return default(Vector2);
		}

		private Vector2 CalculateOrbitRotation(float deviceAxisX, float deviceAxisY)
		{
			return default(Vector2);
		}

		private Vector2 CalculatePanAmount(float deviceAxisX, float deviceAxisY)
		{
			return default(Vector2);
		}

		private void StopCamTransform()
		{
		}

		private void StopFocus()
		{
		}

		private void SetFocusPoint(Vector3 focusPoint)
		{
		}

		private void AdjustOrthoSizeForFocusPt()
		{
		}

		[IteratorStateMachine(typeof(_003CDoSmoothPan_003Ed__129))]
		private IEnumerator DoSmoothPan(float deviceAxisX, float deviceAxisY)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoSmoothLookAround_003Ed__130))]
		private IEnumerator DoSmoothLookAround(float deviceAxisX, float deviceAxisY)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoSmoothOrbit_003Ed__131))]
		private IEnumerator DoSmoothOrbit(float deviceAxisX, float deviceAxisY)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoSmoothZoom_003Ed__132))]
		private IEnumerator DoSmoothZoom(float deviceScroll)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoConstantRotationSwitch_003Ed__133))]
		private IEnumerator DoConstantRotationSwitch(Quaternion targetRotation)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoSmoothRotationSwitch_003Ed__134))]
		private IEnumerator DoSmoothRotationSwitch(Quaternion targetRotation)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoConstantFocus_003Ed__135))]
		private IEnumerator DoConstantFocus(CameraFocus.Data focusData)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoSmoothFocus_003Ed__136))]
		private IEnumerator DoSmoothFocus(CameraFocus.Data focusData)
		{
			return null;
		}

		private void OnPrjSwitchTransitionBegin(CameraPrjSwitchTransition.Type transitionType)
		{
		}

		private void OnPrjSwitchTransitionUpate(CameraPrjSwitchTransition.Type transitionType)
		{
		}

		private void OnPrjSwitchTransitionEnd(CameraPrjSwitchTransition.Type transitionType)
		{
		}
	}
}
