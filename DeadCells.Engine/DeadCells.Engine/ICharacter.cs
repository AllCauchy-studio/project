public interface ICharacter
{
    void TakeDamage(int damage);

    void Heal(float value);

    void Move();

    void DodgeAttack();

    void BlockAttack(int damage);

    void InteractWithObject();

    void Attack(int damage);
}