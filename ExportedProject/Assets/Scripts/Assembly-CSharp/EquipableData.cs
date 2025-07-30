public struct EquipableData
{
	public ObjectPrefab prefabObject;

	public AvatarEquipableType equipableType;

	public EquipableData(ObjectPrefab obj, AvatarEquipableType equipType)
	{
		prefabObject = null;
		equipableType = default(AvatarEquipableType);
	}
}
