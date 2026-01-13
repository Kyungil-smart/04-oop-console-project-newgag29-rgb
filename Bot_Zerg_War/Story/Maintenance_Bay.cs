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

        return "디폴트_메인터넌스";
    }

    public string Maintenance_Bay_Option(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Print_BYREX();
        dialog_18("Dr. 바이렉스 : 그래서 무엇을 할텐가?");
        dialog_19("1. 메인터넌스베이를 나간다 / 2. 닥터 바이렉스와 대화한다 / 3.인벤토리를 정비한다.");
        dialog_22($"현재 HP : {bot.HP}/{bot.MAX_HP}");
        dialog_23($"현재 ATK : {bot.ATK}");
        dialog_24($"현재 DEF : {bot.DEF}");
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
        dialog_22($"현재 HP : {bot.HP}/{bot.MAX_HP}");
        dialog_23($"현재 ATK : {bot.ATK}");
        dialog_24($"현재 DEF : {bot.DEF}");
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
                return "바이렉스다이얼로그";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "디폴트_메인터넌스";
            }
        }
    }

    public string Virex_dialog(BOT bot, Place place, Iventory iventory)
    {
        bool is_MH = false;
        for (int i = 0; i < Iventory.Iven_Slot.GetLength(0); i++)
        {
            for (int j = 0; j < Iventory.Iven_Slot.GetLength(1); j++)
            {
                if (Iventory.Iven_Slot[j, i].OnTileItem is Mutant_Heart)
                {
                    is_MH = true;
                }
            }
        }

        if (is_MH)
        {
            Console.Clear();
            Print_BYREX();
            dialog_18("바이렉스 : 이게무엇인가 BOT?");
            Console.ReadKey(true);
            dialog_18("BOT : 산업구역을 돌아다니다가 우연히 주은것입니다");
            Console.ReadKey(true);
            dialog_18("BOT : 뭔가 제가봐왓던 심장들과는 다르게 독특한 구조를 하고있어 박사님이 좋아하실것 같았습니다");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 흐음,,,,");
            Console.ReadKey(true);
            dialog_18("바이렉스 박사는 돌연변이 저그심장을 유심히 지켜보다가 갑자기 연구실로 들어갔다");
            Console.ReadKey(true);
            dialog_18("그리고 시간이 흐른후");
            Console.ReadKey(true);
            dialog_18("연구실에 들어갔던 박사는 독특한 인공심장을 가지고 나왔다");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 확실이 자네가 가져온 저그심장의 구조는 독특한것이었어,");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 그래서 나는 그 심장의 구조를 보고 아이디어를 얻었네.");
            Console.ReadKey(true);
            dialog_18("자, 여기 새로 고안된 인공심장이야 자네에게 장착하면 성능이 배가될걸세");
            Console.ReadKey(true);
            dialog_18("바이렉스 박사로부터 개선된 인공심장을 받았다");
            Console.ReadKey(true);

            Improved_Artificial_Heart improved_Artificial_Heart = new();
            Iventory.Add(improved_Artificial_Heart);
            Iventory.Remove<Mutant_Heart>();

            return "디폴트_메인터넌스";
        }

        if (((Maintenance_Bay)place).Virex_dialog_1 == true)
        {
            Console.Clear();
            Print_BYREX();
            dialog_18("바이렉스 : 그래서 자네 한번 암시장에 가보는게 어떻겟나?");
            Console.ReadKey(true);
            dialog_18("BOT : 네? 암시장이요??");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 그렇다 암시장, 거기가서 마피아들과 만나줫으면 해");
            Console.ReadKey(true);
            dialog_18("BOT : 마피아 ??? 대체왜 ???");
            Console.ReadKey(true);
            dialog_18("바이렉스 박사의 입에서 나온 의외의 말에 BOT은 잠시 말을 잊지 못했다.");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 아,  그냥 별거아니네 자네가 할일은 그냥이 USB를 마피아 두목에게 전달하고 거기에따른 댓가를 받아오면되");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 그게전부야");
            Console.ReadKey(true);
            dialog_18("BOT : 음,, 대체왜 마피아와 거래를 해야하는지는 잘모르겠지만 박사님의 명령이니 따르겠습니다.");
            Console.ReadKey(true);

            Virex_letter virex_Letter = new Virex_letter();
            Iventory.Add(virex_Letter);
            ((Maintenance_Bay)place).Virex_dialog_1 = false;
            return "디폴트_메인터넌스";
        }

        if (((Maintenance_Bay)place).Virex_dialog_2 == true)
        {
            Console.Clear();
            Print_BYREX();
            dialog_18("바이렉스 : 이보게 BOT!");
            Console.ReadKey(true);
            dialog_18("BOT : 예 박사님");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 자네에게 끝내는 신병기하나를 선물로 주고싶군");
            Console.ReadKey(true);
            dialog_18("BOT : 또 이상한 실험적인 병기를 테스트하겠답시고 저를 괴롭힐 생각이신가요?");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 아 그건아니야 이건 지금까지 하고는 다르다고");
            Console.ReadKey(true);
            dialog_18("BOT : 대체 뭔데요 설명이나 들어봅시다.");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 이것은 무기가 아니라 자네의 에너지 순환 그리드를 향상시키는 일종의 나노머신 세트라네");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 내가 이 나노머신들을 자네몸속에 주입만 하면 자네의 몸에있는 로봇들의 전반적인 성능이");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 두배 세배 이상 껑충 뛰게될것이라네.");
            Console.ReadKey(true);
            dialog_18("BOT : 음,,,,,,");
            Console.ReadKey(true);
            dialog_18("BOT : 뭐 생각해봐야 제가뭘 어쩌겟습니까 결국 박사님 말하는대로 해야지요");
            Console.ReadKey(true);
            dialog_18("바이렉스 : 그래그래 좋은 생각일세");
            Console.ReadKey(true);
            dialog_18("바이렉스 박사의 나노머신이 BOT의 체내에 주입되었다.");
            Console.ReadKey(true);
            dialog_18("BOT의 체력,방어력,공격력이 모두 500씩 증가되었습니다!");
            bot.MAX_HP += 500;
            bot.ATK += 500;
            bot.DEF += 500;
            ((Maintenance_Bay)place).Virex_dialog_2 = false;
            Console.ReadKey(true);

            return "디폴트_메인터넌스";
        }

        return "디폴트_메인터넌스";
    }

    public string Weapon_Change(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine("바이렉스 : 현재 당신이 장착하고있는 아이템들이네 몇번부품의 교체를 원하나?");
        Console.WriteLine("뒤로 가러면 Q 를 누르시오.");

        if (bot.equipped_Weapon[0] != null) { Console.WriteLine($"1번부품 : {bot.equipped_Weapon[0].Name}  / 효과 : {bot.equipped_Weapon[0].Effect_Description}"); }
        else { Console.WriteLine($"1번부품 : 비었음"); }
        if (bot.equipped_Weapon[1] != null) { Console.WriteLine($"2번부품 : {bot.equipped_Weapon[1].Name}  / 효과 : {bot.equipped_Weapon[1].Effect_Description}"); }
        else { Console.WriteLine($"2번부품 : 비었음"); }
        if (bot.equipped_Weapon[2] != null) { Console.WriteLine($"3번부품 : {bot.equipped_Weapon[2].Name}  / 효과 : {bot.equipped_Weapon[2].Effect_Description}"); }
        else { Console.WriteLine($"3번부품 : 비었음"); }
        if (bot.equipped_Weapon[3] != null) { Console.WriteLine($"4번부품 : {bot.equipped_Weapon[3].Name}  / 효과 : {bot.equipped_Weapon[3].Effect_Description}"); }
        else { Console.WriteLine($"4번부품 : 비었음"); }
        if (bot.equipped_Weapon[4] != null) { Console.WriteLine($"5번부품 : {bot.equipped_Weapon[4].Name}  / 효과 : {bot.equipped_Weapon[4].Effect_Description}"); }
        else { Console.WriteLine($"5번부품 : 비었음"); }
        if (bot.equipped_Weapon[5] != null) { Console.WriteLine($"6번부품 : {bot.equipped_Weapon[5].Name}  / 효과 : {bot.equipped_Weapon[5].Effect_Description}"); }
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
