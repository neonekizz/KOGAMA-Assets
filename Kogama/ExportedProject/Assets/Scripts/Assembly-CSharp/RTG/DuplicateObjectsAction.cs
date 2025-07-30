using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class DuplicateObjectsAction : IUndoRedoAction
	{
		private List<GameObject> _rootsToDuplicate;

		private List<GameObject> _duplicateResult;

		private bool _cleanupOnRemovedFromStack;

		public List<GameObject> DuplicateResult => null;

		public DuplicateObjectsAction(List<GameObject> rootsToDuplicate)
		{
		}

		public void Execute()
		{
		}

		public void Undo()
		{
		}

		public void Redo()
		{
		}

		public void OnRemovedFromUndoRedoStack()
		{
		}
	}
}
