namespace DeadCells.Engine
{
    public class Character : ICharacter
    {
        private float _health;
        private float _mana;
        private IWeapon? _weapon;
        private float _armor;
        private IMob? _mob;


        public float Health => _health;
        public float Mana => _mana;
        public IWeapon? Weapon => _weapon;
        public float Armor => _armor;
        public IMob? Mob => _mob;

        public Character(int health, int mana, IWeapon? weapon, int armor)
        {
            _health = health;
            _mana = mana;
            _weapon = weapon;
            _armor = armor;
        }

        public void BlockAttack(int damage)
        {
            TakeDamage(damage / 10);
        }

        public void DodgeAttack()
        {
            throw new NotImplementedException();
        }

        public void Heal(float value)
        {
            _health += value;
        }

        public void InteractWithObject()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
            _armor -= damage / 100;
        }

        public void Attack(int damage)
        {
            Attacker.AttackMob(Mob, Weapon);
        }
    }
}
