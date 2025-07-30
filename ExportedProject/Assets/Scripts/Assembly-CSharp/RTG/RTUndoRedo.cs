using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	public class RTUndoRedo : MonoSingleton<RTUndoRedo>
	{
		private class ActionGroup
		{
			public List<IUndoRedoAction> Actions;

			public ActionGroup(IUndoRedoAction action)
			{
			}
		}

		[SerializeField]
		private bool _isEnabled;

		[SerializeField]
		private int _actionLimit;

		private List<ActionGroup> _actionGroupStack;

		private int _stackPointer;

		public bool IsEnabled => false;

		public int ActionLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event UndoStartHandler UndoStart
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

		public event UndoEndHandler UndoEnd
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

		public event RedoStartHandler RedoStart
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

		public event RedoEndHandler RedoEnd
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

		public event CanUndoRedoHandler CanUndoRedo
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

		public void SetEnabled(bool isEnabled)
		{
		}

		public void ClearActions()
		{
		}

		public void RecordAction(IUndoRedoAction action)
		{
		}

		public void Update_SystemCall()
		{
		}

		private void Undo()
		{
		}

		private void Redo()
		{
		}

		private void RemoveGroups(int startIndex, int count)
		{
		}

		private void OnValidate()
		{
		}
	}
}
