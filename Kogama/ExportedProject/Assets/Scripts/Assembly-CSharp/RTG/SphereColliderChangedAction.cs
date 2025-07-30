namespace RTG
{
	public class SphereColliderChangedAction : IUndoRedoAction
	{
		private SphereColliderSnapshot _preChangeSnapshot;

		private SphereColliderSnapshot _postChangeSnapshot;

		public SphereColliderChangedAction(SphereColliderSnapshot preChangeSnapshot, SphereColliderSnapshot postChangeSnapshot)
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
