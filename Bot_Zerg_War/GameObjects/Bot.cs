
using System.Numerics;

public class BOT
{
    public int CurPos { get; set; }
    public string Name { get; set; } = "BOT";
    public int MAX_HP { get; set; } = 250;
    public int HP { get; set; } = 250;
    
    private int _ATK  = 10;

    public int ATK
    {
        get
        {
            int temp = 0;
            if (equipped_Weapon[0] != null) { temp += equipped_Weapon[0].ATK_Bonus; }
            if (equipped_Weapon[1] != null) { temp += equipped_Weapon[1].ATK_Bonus; }
            if (equipped_Weapon[2] != null) { temp += equipped_Weapon[2].ATK_Bonus; }
            if (equipped_Weapon[3] != null) { temp += equipped_Weapon[3].ATK_Bonus; }
            if (equipped_Weapon[4] != null) { temp += equipped_Weapon[4].ATK_Bonus; }
            if (equipped_Weapon[5] != null) { temp += equipped_Weapon[5].ATK_Bonus; }

            return _ATK + temp;
        }

        set
        {
            _ATK = value;
        } 
    }
    
    public int _DEF  = 0;

    public int DEF
    {
        get
        {
            int temp = 0;
            if (equipped_Weapon[0] != null) { temp += equipped_Weapon[0].DEF_Bonus; }
            if (equipped_Weapon[1] != null) { temp += equipped_Weapon[1].DEF_Bonus; }
            if (equipped_Weapon[2] != null) { temp += equipped_Weapon[2].DEF_Bonus; }
            if (equipped_Weapon[3] != null) { temp += equipped_Weapon[3].DEF_Bonus; }
            if (equipped_Weapon[4] != null) { temp += equipped_Weapon[4].DEF_Bonus; }
            if (equipped_Weapon[5] != null) { temp += equipped_Weapon[5].DEF_Bonus; }

            return _DEF + temp;
        }

        set
        {
            _DEF = value;
        }
    }



    public void Renderer()
    {
        Console.Clear();
        Console.SetCursorPosition(30, 5);
    }

    public Item[] equipped_Weapon = new Item[6];
}



public class Weapon_Attach
{
    Dictionary<string, WeaponSlot> eqiupped = new();
}

public struct WeaponSlot
{

}

