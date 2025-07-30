namespace RTG
{
	public class BoxCollider3DChangedAction : IUndoRedoAction
	{
		private BoxCollider3DSnapshot _preChangeSnapshot;

		private BoxCollider3DSnapshot _postChangeSnapshot;

		public BoxCollider3DChangedAction(BoxCollider3DSnapshot preChangeSnapshot, BoxCollider3DSnapshot postChangeSnapshot)
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
