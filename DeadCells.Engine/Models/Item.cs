public struct Bonus
{
    public string BonusType { get; set; }
    public int Value { get; set; }
}
public class Item
{
    private string? _name;
    private string? _type;
    private string? _description;
    private List<Bonus> _bonuses;
    private ItemRarity _rarity;
    private bool _equiped;

    public string? Name => _name;
    public string? Description => _description;
    public List<Bonus> Bonuses => _bonuses;
    public ItemRarity Rarity => _rarity;
    public bool Equiped => _equiped;
    public string? Type => _type;

    public Item(string name, string description, List<Bonus> bonuses, ItemRarity itemRarity, string type, bool equiped = false)
    {
        _name = name;
        _description = description;
        _bonuses = bonuses;
        _rarity = itemRarity;
        _equiped = equiped;
        _type = type;
    }
}
