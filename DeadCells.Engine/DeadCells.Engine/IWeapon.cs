public interface IWeapon
{
    public ItemRarity Rarity { get; set; }

    public int Strength { get; set; }
    public float Damage { get; set; }

    void Attack();

    void Block();
}
