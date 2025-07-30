using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class TerrainGizmoVerticalOffsetDragEndAction : IUndoRedoAction
	{
		private List<TerrainGizmoAffectedObject> _affectedObjects;

		private Terrain _terrain;

		private float[,] _preChangeHeights;

		private float[,] _postChangeHeights;

		public TerrainGizmoVerticalOffsetDragEndAction(Terrain terrain, float[,] preChangeHeights, float[,] postChangeHeights, List<TerrainGizmoAffectedObject> affectedObjects)
		{
		}

		public void Execute()
		{
		}

		public void OnRemovedFromUndoRedoStack()
		{
		}

		public void Redo()
		{
		}

		public void Undo()
		{
		}
	}
}
