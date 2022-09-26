internal static class Attacker
{
    public static void AttackCharacter(ICharacter character, float damage)
    {
        if (character is null)
            throw new ArgumentNullException(nameof(character));

        if (damage <= 0)
            throw new IndexOutOfRangeException("invalid damage value");

        character.TakeDamage(damage);
    }

    public static void AttackMob(IMob mob, IWeapon weapon)
    {
        if (weapon is null)
            throw new ArgumentNullException(nameof(weapon));

        mob.TakeDamage(weapon);
    }
}
