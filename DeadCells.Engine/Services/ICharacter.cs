public interface ICharacter
{
    public int Level { get; }

    public Dictionary<string, Item> Inventory { get; }
    void TakeDamage(float damage);

    void Heal(float value);

    void Move();

    void DodgeAttack();

    void BlockAttack(float damage);

    bool TryInteractWithObject(object gameObject);

    void Attack(int damage);
}