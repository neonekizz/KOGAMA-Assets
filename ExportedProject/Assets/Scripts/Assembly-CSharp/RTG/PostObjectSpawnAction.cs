using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class PostObjectSpawnAction : IUndoRedoAction
	{
		private bool _cleanupOnRemovedFromStack;

		private List<GameObject> _spawnedParents;

		public PostObjectSpawnAction(List<GameObject> spawnedParents)
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
