using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	public class CameraPrjSwitchTransition
	{
		public enum Type
		{
			None = 0,
			ToOrtho = 1,
			ToPerspective = 2
		}

		[CompilerGenerated]
		private sealed class _003CDoTransition_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CameraPrjSwitchTransition _003C_003E4__this;

			private float _003CfrustumHeight_003E5__2;

			private float _003CtargetFOV_003E5__3;

			private float _003CinvDuration_003E5__4;

			private float _003CfovSpeed_003E5__5;

			private Transform _003C_targetTransform_003E5__6;

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
			public _003CDoTransition_003Ed__41(int _003C_003E1__state)
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

		private IEnumerator _transitionCrtn;

		private MonoBehaviour _targetMono;

		private Camera _targetCamera;

		private float _camFieldOfView;

		private Vector3 _camFocusPoint;

		private Vector3 _camRestorePosition;

		private Type _transitionType;

		private float _durationInSeconds;

		private float _progress;

		public MonoBehaviour TargetMono
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Camera TargetCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type TransitionType => default(Type);

		public float DurationInSeconds
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Progress => 0f;

		public float CamFieldOfView
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 CamFocusPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool IsActive => false;

		public event CameraProjectionSwitchBeginHandler TransitionBegin
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

		public event CameraProjectionSwitchUpdateHandler TransitionUpdate
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

		public event CameraProjectionSwitchBeginHandler TransitionEnd
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

		public void Begin()
		{
		}

		[IteratorStateMachine(typeof(_003CDoTransition_003Ed__41))]
		private IEnumerator DoTransition()
		{
			return null;
		}
	}
}
