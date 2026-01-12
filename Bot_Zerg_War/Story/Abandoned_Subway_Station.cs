public partial class All_Stroy
{
    public string Subway_Default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("버려진 지하철에 더이상 전철은 운영하지않는건 오로지 남은건 시체썩는냄세와 저그의 울음소리뿐..");
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 지하철 내부를 순찰한다");
        Console.WriteLine("2. 지하철내부의 비밀 쉘터로 향한다");
        Console.WriteLine("3. 지하철에 있는 저그를 수색 섬멸한다.");
        Console.WriteLine("4. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "지하철순찰";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "비밀쉘터";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "저그수치";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "나가기";
            }
        }
    }

    public string First_Subway(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine(@"
==============================  
  |  |==================|  |
  |  ||  []  []  []    ||  |
  |  ||                ||  |
__|__||________________||__|__

");

        dialog_18("저그 침공전 매일 다니던 지하철 역으로 들어왔다.");
        Console.ReadKey(true);
        dialog_18("역시나 예상했던대로 예전에 알고있던 지하철역은 흔적도 없이 사라졌다.");
        Console.ReadKey(true);
        dialog_18("그자리를 메꾸고 있는건 파괴된 잔해, 사람들의 시체 그리고....");
        Console.ReadKey(true);
        dialog_18("가끔가다 들려오는 저그들의 울음소리들....");
        Console.ReadKey(true);
        dialog_18("그때 갑자기 뒤에서 무언가가 BOT을 급습하였다");
        Console.ReadKey(true);


        return "저그수치";
    }

    public string secret_shelter(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        if (((Abandoned_Subway_Station)place).secret_shelter_firstcame == true)
        {
            dialog_18("드르륵,,, 쉘터의 문이 열린다");
            Console.ReadKey(true);
            dialog_18("비밀 쉘터안에 있던 사람들은 BOT의 인간스럽지않은 모습을 보자 일단 경계하기 시작했다");
            Console.ReadKey(true);
            dialog_18("야,, 야,, 너 뭐야?");
            Console.ReadKey(true);
            dialog_18("뭐야저건,,, 저그인가??");
            Console.ReadKey(true);
            dialog_18("저그 치고는 너무 기계적으로 생기지않았아?");
            Console.ReadKey(true);
            dialog_18("BOT : 안심하세요 여러분 바이렉스 박사님의 명령을받고 이곳으로 온것입니다 해치지않아요");
            Console.ReadKey(true);
            dialog_18("바이렉스?? 그게 누구인데?");
            Console.ReadKey(true);
            dialog_18("식량을 얻어먹으려고 온것이라면 기대하지마, 우리도 부족하니까.");
            Console.ReadKey(true);
            dialog_18("BOT : ......");
            Console.ReadKey(true);
            dialog_18("BOT : 저그 침공이후 다들 경계심이 높아져있군");
            Console.ReadKey(true);
            ((Abandoned_Subway_Station)place).secret_shelter_firstcame = false;
        }

        Console.Clear();
        Console.WriteLine($"쉘터 내부의 상황은 최악이다 이들은 식량도 물자도 부족하다..");
        Console.WriteLine("1. 쉘터의 주민들에게 식량을 베푼다");
        Console.WriteLine("2. 쉘터의 주민들을 협박하여 물자를 뜯어낸다");
        Console.WriteLine("3. 쉘터 주민들과 물물교환을 한다.");
        Console.WriteLine("4. 쉘터 밖으로나간다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "물자보급";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "물자약탈";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "물물교환";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "디폴트_지하철";
            }
        }
    }

    public string supply(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        if (bot.GOLD < 500)
        {
            dialog_18("골드가 부족합니다.");
            return "비밀쉘터";
        }
        dialog_18("쉘터의 주민들에게 물자를 나눠주었습니다");
        Console.ReadKey(true);
        dialog_18("버려진 지하철의 저그수치가 5 감소하였습니다");
        Console.ReadKey(true);
        ((Abandoned_Subway_Station)place).zergLevel -= 5;
        bot.GOLD -= 500;
        
        return "비밀쉘터";
    }

    public string plunder(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        dialog_18("젠장! 역시 이럴줄 알았어");
        Console.ReadKey(true);
        dialog_18("야 다들 모여 저 괴물을 몰아내자!");
        Console.ReadKey(true);

        Shelter_residents shelter_residents = new Shelter_residents();
        Battle_System.Run(bot, shelter_residents);

        Console.Clear();
        if (bot.HP <= 0)
        {
            dialog_18("어휴 그걸 쳐발리냐 ㅉㅉ...");
            return "디폴트_지하철";
        }
        dialog_18("쉘터 주민들을 무력으로 제압하고 물자를 약탈하였습니다(리튬 배터리)");
        Console.ReadKey(true);
        dialog_18("저그수치가 10 상승하였습니다");
        Console.ReadKey(true);
        ((Abandoned_Subway_Station)place).zergLevel += 10;
        Lithium_battery lithium_battery = new Lithium_battery();
        Iventory.Add(lithium_battery);

        return "디폴트_지하철";
    }
}
