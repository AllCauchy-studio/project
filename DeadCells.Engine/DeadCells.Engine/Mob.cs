public class Mob : IMob
{
    private float _health;
    private int _mana;
    private IWeapon? _weapon;
    private float _armor;
    private ICharacter? _character;

    public float Health => _health;
    public int Mana => _mana;
    public IWeapon? Weapon => _weapon;
    public float Armor => _armor;
    public ICharacter? Character => _character;

    public void Attack(int damage)
    {
        Attacker.AttackCharacter(Character, damage);
    }

    public void TakeDamage(IWeapon weapon)
    {
        _health -= weapon.Damage;
        _armor -= weapon.Damage / 100;
    }
}