public interface IMob
{
    public int Level { get; set; }
    void Attack();

    void TakeDamage(IWeapon weapon);
}
