using System;
using System.Collections.Generic;

namespace DeadCells.Engine
{
    public class Character : ICharacter
    {
        private const int MaxManaValue = 100;
        private const int MaxHealthValue = 100;
        private float _health;
        private float _mana;
        private IWeapon? _weapon;
        private float _armor;
        private IMob? _mob;
        private int _level;
        private Dictionary<string, Item> _inventory;

        public float Health => _health;
        public float Mana => _mana;
        public IWeapon? Weapon => _weapon;
        public float Armor => _armor;
        public IMob? Mob => _mob;
        public int Level => _level;

        public Dictionary<string, Item> Inventory => _inventory;

        public Character(int health = MAX_HEALTH_VALUE, int mana = MAX_MANA_VALUE, IWeapon? weapon = null, int armor = 0, int level = 1, Dictionary<string, Item> inventory = null)
        {
            _health = health;
            _mana = mana;
            _weapon = weapon;
            _armor = armor;
            _level = level;
            _inventory = inventory ?? new Dictionary<string, Item>();
        }

        public void BlockAttack(float damage)
        {
            TakeDamage(damage * 8 / 10);
        }

        public void DodgeAttack()
        {
            throw new NotImplementedException();
        }

        public void Heal(float value)
        {
            _health += value;
        }

        public bool TryInteractWithObject(object gameObject)
        {
            if (gameObject is null)
                return false;

            // interaction
            return true;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(float damage)
        {
            _health -= damage - _armor;
        }

        public void Attack(int damage)
        {
            Attacker.AttackMob(Mob, Weapon);
        }
    }
}
