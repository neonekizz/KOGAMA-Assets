namespace RTG
{
	public class CharacterController3DChangedAction : IUndoRedoAction
	{
		private CharacterController3DSnapshot _preChangeSnapshot;

		private CharacterController3DSnapshot _postChangeSnapshot;

		public CharacterController3DChangedAction(CharacterController3DSnapshot preChangeSnapshot, CharacterController3DSnapshot postChangeSnapshot)
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
