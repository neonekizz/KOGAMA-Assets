namespace RTG
{
	public class SceneRaycastHit
	{
		private GameObjectRayHit _objectHit;

		private XZGridRayHit _gridHit;

		public bool WasAnythingHit => false;

		public bool WasAnObjectHit => false;

		public bool WasGridHit => false;

		public GameObjectRayHit ObjectHit => null;

		public XZGridRayHit GridHit => null;

		public SceneRaycastHit(GameObjectRayHit objectRayHit, XZGridRayHit gridRayHit)
		{
		}
	}
}
