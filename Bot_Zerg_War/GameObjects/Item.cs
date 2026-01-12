public abstract class Item
{
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract string Symbol { get; set; }
    public abstract string Effect_Description { get; set; }
    public abstract int ATK_Bonus { get; set; }
    public abstract int DEF_Bonus { get; set; }
    public abstract int HP_Bonus { get; set; }
}

public class Steel_Pot : Item
{
    public override string Name { get ; set; } = "양철 헬멧";
    public override string Description { get; set; } = "머리에 장착하면 방어력을 25 증가시켜주는 헬멧이다";
    public override string Symbol { get; set; } = "P";
    public override string Effect_Description { get; set; } = "방어력 25 증가";
    public override int ATK_Bonus { get; set; } = 0;
    public override int DEF_Bonus { get; set; } = 25;
    public override int HP_Bonus { get; set; } = 0;
}

public class Steel_Pipe: Item
{
    public override string Name { get; set; } = "쇠파이프";
    public override string Description { get; set; } = "들고 휘두르면 꽤나 무서운 무기가 될수있다";
    public override string Symbol { get; set; } = "S";
    public override string Effect_Description { get; set; } = "공격력 40 증가";
    public override int ATK_Bonus { get; set; } = 40;
    public override int DEF_Bonus { get; set; } = 0;
    public override int HP_Bonus { get; set; } = 0;
}

public class Homemade_Bomb: Item
{
    public override string Name { get; set; } = "사제폭탄";
    public override string Description { get; set; } = "조잡하지만 꽤나 효율적인 무기이다";
    public override string Symbol { get; set; } = "HB";
    public override string Effect_Description { get; set; } = "공격력 70 증가";
    public override int ATK_Bonus { get; set; } = 70;
    public override int DEF_Bonus { get; set; } = 0;
    public override int HP_Bonus { get; set; } = 0;
}


public class Lithium_battery: Item
{
    public override string Name { get; set; } = "리튬배터리";
    public override string Description { get; set; } = "봇에 장착하면 전반적인 성능을 증가시켜줄것이다";
    public override string Symbol { get; set; } = "LB";
    public override string Effect_Description { get; set; } = "ATK + 100, DEF + 100, MAXHP + 750";
    public override int ATK_Bonus { get; set; } = 100;
    public override int DEF_Bonus { get; set; } = 100;
    public override int HP_Bonus { get; set; } = 750;
}

public class Assassin_Knife : Item
{
    public override string Name { get; set; } = "암살자의나이프";
    public override string Description { get; set; } = "상대에게 즉사성 데미지를 가하는 사기장비";
    public override string Symbol { get; set; } = "AK";
    public override string Effect_Description { get; set; } = "ATK + 550";
    public override int ATK_Bonus { get; set; } = 550;
    public override int DEF_Bonus { get; set; } = 0;
    public override int HP_Bonus { get; set; } = 0;
}

public class Smuggled_pistols: Item
{
    public override string Name { get; set; } = "밀수권총";
    public override string Description { get; set; } = "뒷세계에서 살아가는 자들에게 필수장비";
    public override string Symbol { get; set; } = "SP";
    public override string Effect_Description { get; set; } = "ATK + 350";
    public override int ATK_Bonus { get; set; } = 350;
    public override int DEF_Bonus { get; set; } = 0;
    public override int HP_Bonus { get; set; } = 0;
}

public class Suspicious_powder: Item
{
    public override string Name { get; set; } = "수상한가루";
    public override string Description { get; set; } = "성분은 모르겠지만 먹으면 정신이 또렷해진다??";
    public override string Symbol { get; set; } = "PW";
    public override string Effect_Description { get; set; } = "ATK + 150, DEF + 250, HP + 400";
    public override int ATK_Bonus { get; set; } = 150;
    public override int DEF_Bonus { get; set; } = 250;
    public override int HP_Bonus { get; set; } = 400;
}

public class Electric_shock_devices : Item
{
    public override string Name { get; set; } = "전기충격기";
    public override string Description { get; set; } = "대체 이걸 어따가 쓰라고 파는걸까요??";
    public override string Symbol { get; set; } = "ED";
    public override string Effect_Description { get; set; } = "ATK + 300, DEF + 300";
    public override int ATK_Bonus { get; set; } = 300;
    public override int DEF_Bonus { get; set; } = 300;
    public override int HP_Bonus { get; set; } = 0;
}

