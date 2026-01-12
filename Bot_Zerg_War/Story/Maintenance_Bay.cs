public partial class All_Stroy
{
    public string First_Awakening(BOT bot, Place place, Iventory iventory)
    {
        Print_BYREX();

        dialog_18("Dr. 바이렉스 : 아아,, 드디어 깨어났는가?");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 간단히 내 소개를 하면");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 나는 에이드리언 K 루시언 바이렉스.");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 그냥 닥터 바이렉스라고 불러주게.");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 갑자기 내가왜 이런곳에서 깨어났지? 라는 생각이 들면서 의아하기도 할거야..");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 간단하게 말하자면 나는 자네의 생명의 은인 이라네.");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 저그에게 살해당할뻔한걸 내가 겨우 구해냈지.");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 다만 그과정에서 자네의 신체가 너무 훼손되는 바람에");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 자네를 살리기 위해선 사이보그로 만들수 밖에 없었어");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 그래 너도 알다시피 우리도시는 갑자기 등장한 저그들의 공습을 받았지");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 그 공습으로 정규군은 완전히 저그에게 전멸당했지만");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 나는 저그로부터 이 도시를 지켜내려는 희망을 놓치지않았어");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 그래서 내가 개발한 비밀병기와 무기들을 사람들에게 지급해 민병대를 조직해");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 저그의 침공으로부터 맞서싸우는 선택을 했어");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 그결과가 지금현재 이상태");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 현재 도시의 10%는 저그로부터 해방된 상태야 하지만,");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 아직 도시의 남은 90%는 저그에 대해 점령되어있고");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 소수의 사람들은 피난처나 저항기지등을 설치해 저그의 공습으로부터 겨우 스스로를 방어하고있지");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 그래서 나는 자네를 사이보그로 만들때");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 단순히 자네의 생명을 유지하는것뿐만 아니라 ");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 자네를 대 저그용 전투병기로 개조시켰어");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 갑자기 당황스러운 부탁일수만 있지만 저그로부터 이도시를 구해주게");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 만약 자네가 저그와의 전투에서 훼손되면");
        Console.ReadKey(true);
        dialog_18("Dr. 바이렉스 : 내가 자네를 수리해주거나 메인터넌스를 통한 업그레이드를 시켜주도록하지");
        Console.ReadKey(true);

        return "선택화면";
    }

    public string Maintenance_Bay_Option(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Print_BYREX();
        dialog_18("Dr. 바이렉스 : 그래서 무엇을 할텐가?");
        dialog_19("1. 메인터넌스베이를 나간다 / 2. 닥터 바이렉스와 대화한다 / 3.인벤토리를 정비한다.");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if ((int)key.KeyChar - '0' == 1)
            {
                return "나가기";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "바이렉스";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "인벤토리";
            }
        }
    }

    public string Virex(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Print_BYREX();
        dialog_18("Dr. 바이렉스 : 그래 무엇을 도와줄까?");
        dialog_19("1. 메인터넌스를 받는다 / 2. 장비를 교체한다 / 3.바이렉스와 대화한다 / 4. 그만둔다");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                Console.WriteLine("메인터넌스를 통해 당신의 HP가 모두 회복되었습니다");
                bot.HP = bot.MAX_HP;
                Console.ReadKey(true);
                return "바이렉스";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "장비교체";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "인벤토리";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "인벤토리";
            }
        }
    }

    public string Weapon_Change(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine("바이렉스 : 현재 당신이 장착하고있는 아이템들이네 몇번부품의 교체를 원하나?");
        Console.WriteLine("뒤로 가러면 Q 를 누르시오.");

        if (bot.equipped_Weapon[0] != null) { Console.WriteLine($"1번부품 : {bot.equipped_Weapon[0].Name}  / 효과 : {bot.equipped_Weapon[0].Effect_Description}"); }
        else { Console.WriteLine($"1번부품 : 비었음"); }
        if (bot.equipped_Weapon[1] != null) { Console.WriteLine($"1번부품 : {bot.equipped_Weapon[1].Name}  / 효과 : {bot.equipped_Weapon[1].Effect_Description}"); }
        else { Console.WriteLine($"2번부품 : 비었음"); }
        if (bot.equipped_Weapon[2] != null) { Console.WriteLine($"1번부품 : {bot.equipped_Weapon[2].Name}  / 효과 : {bot.equipped_Weapon[2].Effect_Description}"); }
        else { Console.WriteLine($"3번부품 : 비었음"); }
        if (bot.equipped_Weapon[3] != null) { Console.WriteLine($"1번부품 : {bot.equipped_Weapon[3].Name}  / 효과 : {bot.equipped_Weapon[3].Effect_Description}"); }
        else { Console.WriteLine($"4번부품 : 비었음"); }
        if (bot.equipped_Weapon[4] != null) { Console.WriteLine($"1번부품 : {bot.equipped_Weapon[4].Name}  / 효과 : {bot.equipped_Weapon[4].Effect_Description}"); }
        else { Console.WriteLine($"5번부품 : 비었음"); }
        if (bot.equipped_Weapon[5] != null) { Console.WriteLine($"1번부품 : {bot.equipped_Weapon[5].Name}  / 효과 : {bot.equipped_Weapon[5].Effect_Description}"); }
        else { Console.WriteLine($"6번부품 : 비었음"); }


        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "1번교체";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "2번교체";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "3번교체";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "4번교체";
            }
            if ((int)key.KeyChar - '0' == 5)
            {
                return "5번교체";
            }
            if ((int)key.KeyChar - '0' == 6)
            {
                return "6번교체";
            }
            if (key.Key == ConsoleKey.Q)
            {
                return "바이렉스";
            }
        }
    }

    public string First_Weapon(BOT bot, Place place, Iventory iventory)
    {
        Iventory.Iven_Replacement(bot, iventory, 0);
        return "장비교체";
    }

    public string Second_Weapon(BOT bot, Place place, Iventory iventory)
    {
        Iventory.Iven_Replacement(bot, iventory, 1);
        return "장비교체";
    }

    public string Third_Weapon(BOT bot, Place place, Iventory iventory)
    {
        Iventory.Iven_Replacement(bot, iventory, 2);
        return "장비교체";
    }

    public string Fourth_Weapon(BOT bot, Place place, Iventory iventory)
    {
        Iventory.Iven_Replacement(bot, iventory, 3);
        return "장비교체";
    }

    public string Fifth_Weapon(BOT bot, Place place, Iventory iventory)
    {
        Iventory.Iven_Replacement(bot, iventory, 4);
        return "장비교체";
    }

    public string Sixth_Weapon(BOT bot, Place place, Iventory iventory)
    {
        Iventory.Iven_Replacement(bot, iventory, 5);
        return "장비교체";
    }

    public string Iven_Check(BOT bot, Place place, Iventory iventory)
    {
        Iventory.Iven_Search();
        return "디폴트_메인터넌스";
    }
}
