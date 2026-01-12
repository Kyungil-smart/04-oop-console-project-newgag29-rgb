public partial class All_Stroy
{
    public string street_default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("거리곳곳은 저그와의 전투로인해 파괴의 흔적들이 남아있고 사람들은 누더기만 걸치고");
        Console.WriteLine("쥐나 음식물쓰레기를 뒤져먹으며 간신히 연명하고있다.");
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 도시를 순찰한다");
        Console.WriteLine("2. 거리에 있는 사람에게 말을건다");
        Console.WriteLine("3. 도시안에 있는 저그를 수색 섬멸한다.");
        Console.WriteLine("4. 암시장으로 향한다");
        Console.WriteLine("5. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "도시순찰";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "거리시민";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "저그수치";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "암시장";
            }
            if ((int)key.KeyChar - '0' == 5)
            {
                return "나가기";
            }
        }
    }

    public string First_street(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();

        Console.WriteLine(@"
    |||||      ||||
     |||||  __  ||||
 ____|||||_|__|_||||____
 | []  []  []  []  []  |
 | []  XX  XX  []  []  |
 | []  XX  []  []  XX  |
_|____[]____[]____[]____|_
   /\/\        /\/\
  /____\______/____\
");

        dialog_18("BOT : 대체 이게뭐야....?");
        Console.ReadKey(true);
        dialog_18("바이렉스 박사의 연구실에서 나와 도시거리로 나오자 지옥과같은 풍경이 펼쳐져있었다.");
        Console.ReadKey(true);
        dialog_18("한때 번성했던 번화가는 저그와 민방위군의 전투로인해 산산히 파괴되어있었고.");
        Console.ReadKey(true);
        dialog_18("길 곳곳에는 저그와 인간들의 시체가 널부러져 있었다");
        Console.ReadKey(true);
        dialog_18("BOT : 처참하다... 진짜 바이렉스 말이 사실이었던거야?");
        Console.ReadKey(true);
        dialog_18("??? : 쿠와아아앙!");
        Console.ReadKey(true);
        dialog_18("그때 어디선가 괴생물체의 비명소리가 들려왔다");
        Console.ReadKey(true);
        dialog_18("BOT이 소리의 근원지를 돌아보자 어떤 사람키보다 조금 작아보이는 괴생물체가 서있었다");
        Console.ReadKey(true);
        dialog_18("BOT : 뭐야 이 조그마한 괴물은.. 혹시 이게 말로만듣던 저글링??");

        return "저글링";
    }

    public string Battle_angry_mob(BOT bot, Place place, Iventory iventory)
    {
        angry_mob mob = new angry_mob();
        Battle_System.Run(bot, mob);

        return "성난군중전투후";
    }

    

    public string street_patrol(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine(@"
    |||||      ||||
     |||||  __  ||||
 ____|||||_|__|_||||____
 | []  []  []  []  []  |
 | []  XX  XX  []  []  |
 | []  XX  []  []  XX  |
_|____[]____[]____[]____|_
   /\/\        /\/\
  /____\______/____\
");
        City_Streets street = (City_Streets)place;
        if (street.first_came == true)
        {
            street.first_came = false;
            dialog_18("BOT은 폐허가된 거리를 걸어다닌다.");
            Console.ReadKey(true);
            dialog_18("도시는 완전히폐허가 되있었다 그리고 곳곳에는 부모를 잃은 고아들이 울거나, 도둑질을하며 생계를 이어나가고있었다");
            Console.ReadKey(true);
            dialog_18("BOT : 이건 너무....");
            Console.ReadKey(true);
            dialog_18("BOT : 이게다 저그들 때문이라고?");
            Console.ReadKey(true);
            dialog_18("그때 한사람이 BOT의 앞을 가로막았다");
            Console.ReadKey(true);
            dialog_18("저그다! 저그가 나타났다!!");
            Console.ReadKey(true);
            dialog_18("뭐? 저그라고??");
            Console.ReadKey(true);
            dialog_18("저그를 죽여버려!!!");
            Console.ReadKey(true);
            dialog_18("BOT : 잠깐.. 잠깐만! 난 저그가 아니라고!!");
            Console.ReadKey(true);
            dialog_18("BOT은 성난 군중들에게 자신은 저그가아니며 오히려 당신들을 지켜주기위해 온것이라 설명하려 노력하였다");
            Console.ReadKey(true);
            dialog_18("하지만 저그들에게 자신의 가족이나 소중한 사람 그리고 삶의 터전을 잃은 사람들에게");
            Console.ReadKey(true);
            dialog_18("이성과 논리따위가 먹힐리가 없었다 오로지 그들에게 필요한것을 화풀이를 할 대상이었다");
            Console.ReadKey(true);

            return "전투_성난군중";
        }

        dialog_18("도시를 순찰하였다");
        Console.ReadKey(true);
        int temp = Master.rand.Next(0, 3);
        if (temp == 0)
        {
            dialog_18("도시를 순찰하다 아이템을 주웠다!");
            dialog_19("획득한 아이템 : 쇠파이프");
            Steel_Pipe steel_Pipe = new Steel_Pipe();
            Iventory.Add(steel_Pipe);
            Console.ReadKey(true);
            return "디폴트_도시거리";
        }
        if (temp == 1)
        {
            dialog_18("도시를 순찰하다 저그와 마주쳣다!");
            return "저그수치";
        }
        if (temp == 2)
        {
            dialog_18("도시를 순찰하다 아이템을 주웠다!");
            dialog_19("획득한 아이템 : 사제폭탄");
            Homemade_Bomb homemade_Bomb = new Homemade_Bomb();
            Iventory.Add(homemade_Bomb);
            Console.ReadKey(true);
            return "디폴트_도시거리";
        }


        return "디폴트_도시거리";
    }

    public string after_fightwith_mob(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine(@"
   (・_・)   (・_・)
     |         |
    / \       / \

 (・_・)   (・_・)
     |         |
    / \       / \
");


        dialog_18("그러니까 당신은 저그라 아니라는거지?");
        Console.ReadKey(true);
        dialog_18("지금 가만보니까 저그치고는 많이 인간처럼 생겼군");
        Console.ReadKey(true);
        dialog_18("아니 딱봐도 저그가아닌데 다굴치자고 한놈이 누구야?");
        Console.ReadKey(true);
        dialog_18("BOT : 저는 바이렉스 박사가 보내서 이리로 온것뿐입니다/");
        Console.ReadKey(true);
        dialog_18("네??  바이렉스 박사님이요??");
        Console.ReadKey(true);
        dialog_18("아이구,, 죄송했습니다");
        Console.ReadKey(true);
        dialog_18("사죄의 의미로 이걸 드리지요");
        Console.ReadKey(true);
        dialog_18("당신은 양철통 헬멧을얻었다");
        Steel_Pot steel_Pot = new Steel_Pot();
        Iventory.Add(steel_Pot);
        Console.ReadKey(true);

        return "디폴트_도시거리";
    }

    public string Black_market(BOT bot, Place place, Iventory iventory)
    {
        if (((City_Streets)place).Black_market_first == true)
        {
            Console.Clear();
            dialog_18("암시장에 처음 진입하자 마자 그곳에서는 온갖 불법적인 상품들이 거래된다는것을 알 수 있었다 ");
            Console.ReadKey(true);
            dialog_18("BOT이 처음와보는 암시장을 두리번 거리고 있을때 한남자가 BOT에게 말을 걸었다");
            Console.ReadKey(true);
            dialog_18("의문의 남자 : 아무래도 자네 인간은 아닌거같은데,, 그렇다고 저그도 아닌가?");
            Console.ReadKey(true);
            dialog_18("저는 인간입니다 단지 불의의 사고때문에 인간의 신체만으로는 생존이 불가능한 처지에 놓인것 뿐이지요.");
            Console.ReadKey(true);
            dialog_18("의문의 남자 : 그것을 바로 인간이 아니라고 하는거라네 하하...");
            Console.ReadKey(true);
            dialog_18("의문의 남자 : 그럼 내가 자네에게 하나만 묻지,, 자네눈에는  내가 인간으로 보이는가?");
            Console.ReadKey(true);
            dialog_18("네 ???");
            Console.ReadKey(true);
            dialog_18("의문의 남자 : 하하 그냥 흘려들으면 되네, ");
            Console.ReadKey(true);
            dialog_18("의문의 남자 : 자네,, 바이렉스 박사가 보낸거지??");
            Console.ReadKey(true);
            dialog_18("아니 그걸 어떻게???");
            Console.ReadKey(true);
            dialog_18("하하,, 다 아는 방법이 있다네,, 이거받도록해");
            Console.ReadKey(true);
            dialog_18("암살자의 나이프가 인벤토리에 추가되었다.");
            Assassin_Knife assassin_Knife = new Assassin_Knife();
            Iventory.Add(assassin_Knife);
            Console.ReadKey(true);
            dialog_18("대체 이건??? ");
            Console.ReadKey(true);
            dialog_18("의문의 남자 : 그냥받도록해 좋은거야");
            Console.ReadKey(true);
            dialog_18("대체 당신은 누구길레 저한테 이런??");
            Console.ReadKey(true);
            dialog_18("언젠가 다시 만나자고"); 
            ((City_Streets)place).Black_market_first = false;
            Console.ReadKey(true);
        }

        Console.Clear();

        Console.WriteLine("암시장은 범죄가 사회부적응자 마약중독자들 같은 끔찍한것들로 넘쳐나고 있었다.. 하지만 가장 최악인것은 없었으니");
        Console.WriteLine("그것은 바로 저그.");
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 상점에 방문한다");
        Console.WriteLine("2. 수상해보이는 빌딩을 조사한다");
        Console.WriteLine("3. 마피아와 접선한다.");
        Console.WriteLine("4. 암시장을 떠난다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "암시장_상점";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "수상한빌딩";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "마피아접선";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "디폴트_도시거리";
            }
        }
    }

    public string Black_market_store(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();

        Console.WriteLine("살게 있으면 사가던가..");
        Console.WriteLine("1. 밀수권총 : 750G");
        Console.WriteLine("2. 수상한가루 : 1000G");
        Console.WriteLine("3. 전기충격기 : 600G.");
        Console.WriteLine("4. 이전단계로");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                if(bot.GOLD > 750)
                {
                    dialog_18("밀수권총을 구매하셨습니다.");
                    bot.GOLD -= 750;
                    Smuggled_pistols smuggled_Pistols = new();
                    Iventory.Add(smuggled_Pistols);
                    Console.ReadKey(true);
                    return "암시장_상점";
                }
                else
                {
                    dialog_18("돈이 없서요 ㅠㅠ.");
                    Console.ReadKey(true);
                    return "암시장_상점";
                }
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                if (bot.GOLD > 1000)
                {
                    dialog_18("수상한 가루를 구매하셨습니다.");
                    bot.GOLD -= 1000;
                    Suspicious_powder suspicious_Powder = new();
                    Iventory.Add(suspicious_Powder);
                    Console.ReadKey(true);
                    return "암시장_상점";
                }
                else
                {
                    dialog_18("돈이 없서요 ㅠㅠ.");
                    Console.ReadKey(true);
                    return "암시장_상점";
                }
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                if (bot.GOLD > 600)
                {
                    dialog_18("전기충격기를 구매하셨습니다.");
                    bot.GOLD -= 600;
                    Electric_shock_devices electric_Shock_Devices = new();
                    Iventory.Add(electric_Shock_Devices);
                    Console.ReadKey(true);
                    return "암시장_상점";
                }
                else
                {
                    dialog_18("돈이 없서요 ㅠㅠ.");
                    Console.ReadKey(true);
                    return "암시장_상점";
                }
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "암시장";
            }
        }
    }

    public string Suspicious_Building(BOT bot, Place place, Iventory iventory)
    {
        if (((City_Streets)place).Suspicious_Building_first == false)
        {
            Console.Clear();
            dialog_18("이미한번본 이벤트를 다시 볼 필요는 없습니다");
            Console.ReadKey(true);
            return "암시장";
        }

        Console.Clear();
        dialog_18("건물안으로 들어서자 퀘퀘한 냄세가 코를 찔렀다");
        Console.ReadKey(true);
        dialog_18("대체 이게 무슨냄세야");
        Console.ReadKey(true);
        dialog_18("그때 BOT의 뒤에서 어떤 소리가 들려온다");
        Console.ReadKey(true);
        dialog_18("??? : 너가 바이렉스가 보낸 그 사이보그 인가?");
        Console.ReadKey(true);
        dialog_18("내가 바이렉스 박사와 관련있는건 맞긴한데? 근데 대체왜??");
        Console.ReadKey(true);
        dialog_18("나는 저그하고 싸우는 정의의 편이라고.");
        Console.ReadKey(true);
        dialog_18("??? : 그래,, 그렇단 말이지,,? 그럼 죽어라.");
        Console.ReadKey(true);
        dialog_18("BOT 아니 잠깐 왜이래 난나쁜사람이 아니라까?!?!");
        Console.ReadKey(true);
        dialog_18("의문의 괴환들이 당신을 공격해왔다.");
        Console.ReadKey(true);

        UnknownHostiles unknownHostiles = new UnknownHostiles();
        Battle_System.Run(bot, unknownHostiles);

        if (bot.HP <= 0)
        {
            return "디폴트_도시거리";
        }

        dialog_18("??? : 젠장,,, 대체왜 이렇게 강한거야??");
        Console.ReadKey(true);
        dialog_18("BOT : 너야말로 대체왜 아무잘못도 없는 나를 공격하는거야?!");
        Console.ReadKey(true);
        dialog_18("??? : 아무 잘못도 없어?? 푸하하하하");
        Console.ReadKey(true);
        dialog_18("BOT : ?? 대체 이게 무슨반응이지?");
        Console.ReadKey(true);
        dialog_18("??? : 하긴 너는 모를수도 있겠구나.");
        Console.ReadKey(true);
        dialog_18("??? : 에이드리언 K 루시언 바이렉스의 진짜 정체는");
        Console.ReadKey(true);
        dialog_18("푸욱!");
        Console.ReadKey(true);
        dialog_18("갑자기 어디선가 칼날이 날아와 의문의 남자의 목을 찢어버렷다");
        Console.ReadKey(true);
        dialog_18("그 칼날의 정체는 바로 BOT의 복부에서 갑자기 사출된 칼날이였다");
        Console.ReadKey(true);
        dialog_18("바이렉스 : 이보게 BOT 괞찮은가??");
        Console.ReadKey(true);
        dialog_18("네 박사님 저는 문제없습니다");
        Console.ReadKey(true);
        dialog_18("바이렉스 : 당장 메인터넌스 베이로 복귀하게 너는 지금 수리해야할곳이 많아");
        Console.ReadKey(true);
        dialog_18("네 알겠습니다!");
        Console.ReadKey(true);
        dialog_18("대체 저 남자는 무슨말을 하려했던거지...");
        Console.ReadKey(true);
        dialog_18("의문의 USB를 획득하였습니다");
        Console.ReadKey(true);
        Mysterious_USB mysterious_USB = new Mysterious_USB();
        Iventory.Add(mysterious_USB);
        ((City_Streets)place).Suspicious_Building_first = false;

        return "암시장";
    }

    public string Mafia_contact(BOT bot, Place place, Iventory iventory)
    {
        if (((City_Streets)place).Mafia_visit == true)
        {
            Console.Clear();
            dialog_18("같은 이벤트를 두번볼 필요는 없습니다");
            return "암시장";
        }
        
        bool is_letter = false;
        for (int i = 0; i < Iventory.Iven_Slot.GetLength(0); i++)
        {
            for (int j = 0; j < Iventory.Iven_Slot.GetLength(2); j++)
            {
                if (Iventory.Iven_Slot[j, i].OnTileItem is Virex_letter)
                {
                    is_letter = true;
                }
            }
        }

        if (!is_letter)
        {
            Console.Clear();
            dialog_18("마피아들과의 접선을 위해서는 바이렉스의 초대장이 필요합니다");
            Console.ReadKey(true);
            return "암시장";
        }
        else
        {
            Console.Clear();
            dialog_18("확실히 이건 바이렉스 박사의 필체가 맞군...");
            Console.ReadKey(true);
            dialog_18("");
            Console.ReadKey(true);
            dialog_18("");
            Console.ReadKey(true);
            dialog_18("");
            Console.ReadKey(true);
            dialog_18("");
            Console.ReadKey(true);
            dialog_18("");
            Console.ReadKey(true);
            dialog_18("");
            Console.ReadKey(true);
            dialog_18("");
            Console.ReadKey(true);
            dialog_18("");
            Console.ReadKey(true);
        }
    }
}
