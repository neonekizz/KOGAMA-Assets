using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.WorldObjectTypes.EditablePickupItem;
using RTG;
using UnityEngine;

namespace Assets.Scripts.WorldObjectTypes.CustomGun
{
	internal class MVCustomGunBlueprint : MVEditablePickupItemBaseBlueprint
	{
		[CompilerGenerated]
		private sealed class _003CMuzzleBoundCheckRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MVCustomGunBlueprint _003C_003E4__this;

			private Vector3 _003Cmax_003E5__2;

			private Vector3 _003Cmin_003E5__3;

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
			public _003CMuzzleBoundCheckRoutine_003Ed__17(int _003C_003E1__state)
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

		private const float Offset = 0.01f;

		private GameObject muzzlePoint;

		private ObjectTransformGizmo transformGizmo;

		private IEnumerator muzzleBoundCheckRoutine;

		protected override float CubeModelScale => 0f;

		public override MVWorldObjectDocumentationType DocumentationType => default(MVWorldObjectDocumentationType);

		public MVCustomGunBlueprint(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override void Initialize()
		{
		}

		protected override void SetCubeSize()
		{
		}

		public override bool OnEnterObject(EditorStateMachine e)
		{
			return false;
		}

		public override void OnEndEditing()
		{
		}

		private void EnterMuzzleEdit()
		{
		}

		private void EndMuzzleEdit()
		{
		}

		private void ResetMuzzlePosition()
		{
		}

		private void ResetMuzzleRotation()
		{
		}

		[IteratorStateMachine(typeof(_003CMuzzleBoundCheckRoutine_003Ed__17))]
		private IEnumerator MuzzleBoundCheckRoutine()
		{
			return null;
		}

		private void SetMuzzlePointPosition(Vector3 pos)
		{
		}
	}
}
