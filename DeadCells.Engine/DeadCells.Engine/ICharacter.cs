public interface ICharacter
{
    public int Level { get; set; }
    
    public List<Item> Inventory { get; set; }
    void TakeDamage(int damage);

    void Heal(float value);

    void Move();

    void DodgeAttack();

    void BlockAttack(int damage);

    void InteractWithObject();

    void Attack(int damage);
}