using System.Collections.Generic;

namespace RTG
{
	public class TerrainGizmoObjectTransformsChangedAction : IUndoRedoAction
	{
		private List<LocalTransformSnapshot> _preChangeTransformSnapshots;

		private List<LocalTransformSnapshot> _postChangeTransformSnapshots;

		public TerrainGizmoObjectTransformsChangedAction(List<LocalTransformSnapshot> preChangeTransformSnapshots, List<LocalTransformSnapshot> postChangeTransformSnapshots)
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
