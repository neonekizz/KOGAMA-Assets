namespace RTG
{
	public interface IUndoRedoAction
	{
		void Execute();

		void Undo();

		void Redo();

		void OnRemovedFromUndoRedoStack();
	}
}
