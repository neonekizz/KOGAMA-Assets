namespace RTG
{
	public class Light3DChangedAction : IUndoRedoAction
	{
		private Light3DSnapshot _preChangeSnapshot;

		private Light3DSnapshot _postChangeSnapshot;

		public Light3DChangedAction(Light3DSnapshot preChangeSnapshot, Light3DSnapshot postChangeSnapshot)
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
