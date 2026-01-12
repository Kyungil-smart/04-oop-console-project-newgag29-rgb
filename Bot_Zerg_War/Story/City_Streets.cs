public partial class All_Stroy
{
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
}
