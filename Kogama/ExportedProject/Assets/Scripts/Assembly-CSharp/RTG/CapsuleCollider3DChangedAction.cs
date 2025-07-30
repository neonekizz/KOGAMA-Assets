namespace RTG
{
	public class CapsuleCollider3DChangedAction : IUndoRedoAction
	{
		private CapsuleCollider3DSnapshot _preChangeSnapshot;

		private CapsuleCollider3DSnapshot _postChangeSnapshot;

		public CapsuleCollider3DChangedAction(CapsuleCollider3DSnapshot preChangeSnapshot, CapsuleCollider3DSnapshot postChangeSnapshot)
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
