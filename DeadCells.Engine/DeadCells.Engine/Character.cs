namespace DeadCells.Engine
{
    public class Character : ICharacter
    {
        private float _health;
        private float _mana;
        private IWeapon? _weapon;
        private float _armor;
        private IMob? _mob;
        private int _level;
        private List<Item> _inventory;
        private const int MAX_MANA_VALUE = 100;
        private const int MAX_HEALTH_VALUE = 100;

        public float Health => _health;
        public float Mana => _mana;
        public IWeapon? Weapon => _weapon;
        public float Armor => _armor;
        public IMob? Mob => _mob;
        public int Level { get => _level; set => _level = value; }
        public List<Item>? Inventory { get => _inventory ??= new List<Item>(); set => _inventory ??= value; }


        public Character(int health = MAX_HEALTH_VALUE, int mana = MAX_MANA_VALUE, IWeapon? weapon = null, int armor = 0, int level = 1, List<Item> inventory = null)
        {
            _health = health;
            _mana = mana;
            _weapon = weapon;
            _armor = armor;
            _level = level;
            _inventory = inventory ?? new List<Item>();
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
