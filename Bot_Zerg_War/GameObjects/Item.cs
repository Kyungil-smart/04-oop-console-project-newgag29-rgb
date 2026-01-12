public abstract class Item
{
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract string Symbol { get; set; }
    public abstract string Effect_Description { get; set; }
    public abstract int ATK_Bonus { get; set; }
    public abstract int DEF_Bonus { get; set; }
}

public class Steel_Pot : Item
{
    public override string Name { get ; set; } = "양철 헬멧";
    public override string Description { get; set; } = "머리에 장착하면 방어력을 10 증가시켜주는 헬멧이다";
    public override string Symbol { get; set; } = "P";
    public override string Effect_Description { get; set; } = "방어력 10 증가";
    public override int ATK_Bonus { get; set; } = 0;
    public override int DEF_Bonus { get; set; } = 10;
}

