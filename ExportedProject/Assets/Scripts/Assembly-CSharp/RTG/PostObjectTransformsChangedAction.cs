using System.Collections.Generic;

namespace RTG
{
	public class PostObjectTransformsChangedAction : IUndoRedoAction
	{
		private List<LocalTransformSnapshot> _preChangeTransformSnapshots;

		private List<LocalTransformSnapshot> _postChangeTransformSnapshots;

		public PostObjectTransformsChangedAction(List<LocalTransformSnapshot> preChangeTransformSnapshots, List<LocalTransformSnapshot> postChangeTransformSnapshots)
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
