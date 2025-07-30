using System.Collections.Generic;

namespace RTG
{
	public class PostGizmoTransformsChangedAction : IUndoRedoAction
	{
		private List<LocalGizmoTransformSnapshot> _preChangeTransformSnapshots;

		private List<LocalGizmoTransformSnapshot> _postChangeTransformSnapshots;

		public PostGizmoTransformsChangedAction(List<LocalGizmoTransformSnapshot> preChangeTransformSnapshots, List<LocalGizmoTransformSnapshot> postChangeTransformSnapshots)
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
