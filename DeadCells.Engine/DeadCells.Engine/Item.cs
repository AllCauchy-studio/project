public struct Bonus
{
    public string BonusType { get; set; }
    public int Value { get; set; }
}
public class Item
{
    private string? _name;
    private string? _description;
    private List<Bonus> _bonuses;
    private ItemRarity _rarity;

    public string? Name => _name;
    public string? Description => _description;
    public List<Bonus> Bonuses => _bonuses;
    public ItemRarity Rarity => _rarity;

    public Item(string name, string description, List<Bonus> bonuses, ItemRarity itemRarity)
    {
        _name = name;
        _description = description;
        _bonuses = bonuses;
        _rarity = itemRarity;
    }
}
