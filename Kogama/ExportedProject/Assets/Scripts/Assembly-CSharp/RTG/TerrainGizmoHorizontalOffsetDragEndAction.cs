using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class TerrainGizmoHorizontalOffsetDragEndAction : IUndoRedoAction
	{
		private List<LocalTransformSnapshot> _preChangeSnapshots;

		private List<LocalTransformSnapshot> _postChangeSnapshots;

		private Vector3 _preChangeGizmoPos;

		private Vector3 _postChangeGizmoPos;

		private TerrainGizmo _terrainGizmo;

		public TerrainGizmoHorizontalOffsetDragEndAction(TerrainGizmo terrainGizmo, Vector3 preChangeGizmoPos, List<LocalTransformSnapshot> preChangeSnapshots, List<LocalTransformSnapshot> postChangeSnapshots)
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
