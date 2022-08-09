public interface IMob
{
    public int Level { get; set; }
    void Attack(int damage);

    void TakeDamage(IWeapon weapon);
}
