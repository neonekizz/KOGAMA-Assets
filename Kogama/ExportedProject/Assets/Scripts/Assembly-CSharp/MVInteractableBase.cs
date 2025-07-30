using MV.Common;

public abstract class MVInteractableBase : MVComponent
{
	public abstract void TakeDamage(float amount, MVPlayer damageDealer, PlayerKilledByType damageType);

	public abstract void TakeDamageOverTime(AvatarModifierPackageType type, MVPlayer damageDealer, PlayerKilledByType damageType);

	public abstract void Heal(float amount, MVPlayer healer);

	public abstract void HealOverTime(AvatarModifierPackageType type, MVPlayer healer);

	public abstract void AddModifier(AvatarModifierPackageType type, int id = -1, AvatarModifierPackage.AvatarModifier[] additionalModifers = null);

	public abstract bool HasModifier(AvatarModifierPackageType type);

	public abstract void RemoveModifier(AvatarModifierPackageType type, int id = -1);

	public abstract bool HasModifierEffect(AvatarModifierEffect avatarModifierEffect);

	public abstract float HandleModifierEffect(AvatarModifierEffect avatarModifierEffect, float baseValue);

	public abstract void ClearModifiers();
}
