using System.Security.Cryptography.X509Certificates;

public partial class All_Stroy
{
    public string Industrial_Default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("파괴된 산업시설에서 쏟아져나오는 산업폐기물가 독가스는 인체에 치명적이였으나,");
        Console.WriteLine("몇몇 저그종들은 그것에 적응하여 오히려 그것을 식량으로 사용하는것같다.");
        Console.WriteLine("1. 파괴된 산업구역을 순찰한다");
        Console.WriteLine("2. 폐공장 내부로 진입한다");
        Console.WriteLine("3. 파괴된 산업구역에 있는 저그를 수색 섬멸한다.");
        Console.WriteLine("4. 변형체와 조우한다");
        Console.WriteLine("5. 토라스크와 조우한다.");
        Console.WriteLine("6. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "산업구역순찰";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "폐공장";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "저그수치";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "변형체";
            }
            if ((int)key.KeyChar - '0' == 5)
            {
                return "토라스크";
            }
            if ((int)key.KeyChar - '0' == 6)
            {
                return "나가기";
            }
        }
    }

    public string Abandoned_Factory(BOT bot, Place place, Iventory iventory)
    {
        if (((Industrial_Zone)place).Abandoned_Factory_1 == false)
        {
            Console.Clear();
            dialog_18("이미 한번본 이벤트를 다시 볼 필요는 없습니다");
            return "디폴트_산업구역";
        }

        Console.Clear();
        dialog_18("폐공장 내부는 생각햇던것과는 달리 유독물질의 농도가 그렇게 높지안았다");
        Console.ReadKey(true);
        dialog_18("BOT : 의외의 광경인데,, 화학물질이 가득한 공장내부 그리고 밀폐된 환경");
        Console.ReadKey(true);
        dialog_18("BOT : 이상하다 대기중 맹독의 농도가 극도로 높아도 이상하지 않을 환경인데....");
        Console.ReadKey(true);
        dialog_18("BOT : 생각보다 맹독의 농도가 높지는 않잖아?");
        Console.ReadKey(true);
        dialog_18("하지만 BOT은 이내 자신의 생각을 바꾸었다.");
        Console.ReadKey(true);
        dialog_18("폐공장 내부의 대기가 깨끗하다고 착각한것은 그가 보고있던 계기판이 오로지 인간이 생산한");
        Console.ReadKey(true);
        dialog_18("화학물질만을 게측하게 설계되어 있었기 때문이었다");
        Console.ReadKey(true);
        dialog_18("AI : 삐빅,, 대기중  이상물질 감지 ");
        Console.ReadKey(true);
        dialog_18("AI : 유독물질에 의해 독성 방어 시스템이 작동합니다");
        Console.ReadKey(true);
        dialog_18("BOT : 뭐야,, 계기판에는 아무이상 없다고 나오는데");
        Console.ReadKey(true);
        dialog_18("AI : 대기중에 지금까지 발견하지 못했던 이상물질 대거감지");
        Console.ReadKey(true);
        dialog_18("AI : 아무래도 저그가 생성해낸 물질로 추정됩니다.");
        Console.ReadKey(true);
        dialog_18("그래, 그럼그렇지 이 시국에 깨끗하고 안전한 장소가 있을리가");
        Console.ReadKey(true);
        dialog_18("기존에 있던 인공 화학물질은 저그가 다 흡수해버리고");
        Console.ReadKey(true);
        dialog_18("그것을 흡수한 저그가 새로운 자신만의 화학물질을 대기중에 살포한 것이로군.");
        Console.ReadKey(true);
        dialog_18("BOT은 폐공장을 수색하다가 그 장본인을  금세 발견할 수 있었다.");
        Console.ReadKey(true);
        dialog_18("BOT : 이건대체뭐야?");
        Console.ReadKey(true);
        dialog_18("주변을 수색하고 있는데 무언가 기괴한 점막같은것이 BOT의 눈에 포착되었다");
        Console.ReadKey(true);
        dialog_18("BOT : 혹시 이 점막이 괴상한 독성기체를 내뿜는거냐?");
        Console.ReadKey(true);
        dialog_18("AI : 삐빅, 조사결과 맞습니다");
        Console.ReadKey(true);
        dialog_18("BOT : 음,,,");
        Console.ReadKey(true);
        dialog_18("BOT은 잠시 생각하더니 점막이 펼쳐진곳을 따라 점막의 중심부를 향해 걸어갔다");
        Console.ReadKey(true);
        dialog_18("BOT이 점막의 근원지를 향해 걸어갈수록 벽과 바닥을 점유하고잇는 점막의 면적이 넓어졋고");
        Console.ReadKey(true);
        dialog_18("벽과 바닥을 점유하고잇는 점막의 면적이 넓어질수록, 대기중의 독성물질의 농도도 증가하였다");
        Console.ReadKey(true);
        dialog_18("AI : 점점 인류가 아직 알지못하는 극독성의 신종 화학물질의 종류가 증가하고있습니다");
        Console.ReadKey(true);
        dialog_18("AI : BOT님 이대로면 앞으로 30분정도가 한계입니다.");
        Console.ReadKey(true);
        dialog_18("BOT : 음,,,,");
        Console.ReadKey(true);
        dialog_18("그렇게 점막을 계속 따라던 BOT은 어느 한 방문앞에 멈춰섰다");
        Console.ReadKey(true);
        dialog_18("BOT : 화학 폐기물 저장동 이라....");
        Console.ReadKey(true);
        dialog_18("BOT : 고농도의 화학폐기물을 먹고 저그점막이 이렇게까지 성장한건가?");
        Console.ReadKey(true);
        dialog_18("BOT은 화학저장동의 문을 열러고 시도 하였으나 생각대로 잘 풀리지않았다.");
        Console.ReadKey(true);
        dialog_18("BOT : 칫... 제길....");
        Console.ReadKey(true);
        dialog_18("결국 BOT은 강제로 문을 부수고 안으로 진입하였다");
        Console.ReadKey(true);
        dialog_18("AI : 삐빅! 극독성 화학물질의 농도 매우높음");
        Console.ReadKey(true);
        dialog_18("AI 앞으로 10분뒤 해독시스템이 다운됩니다.");
        Console.ReadKey(true);
        dialog_18("화학저장동의 이라는 곳의 안은 완벽히 저그 점막들로 뒤덮혀 있었고 그곳에서 뿜어져나오는 독성기체의 농도와 위험성은 상상을 초월하였다");
        Console.ReadKey(true);
        dialog_18("우워어어어,, 휘리리릭!");
        Console.ReadKey(true);
        dialog_18("그때 화학저장동의 점막에서 괴상한 촉수들이 솟아나왓다");
        Console.ReadKey(true);
        dialog_18("BOT : 그래,, 침입자를 제거하겠다 이건가?");
        Console.ReadKey(true);
        dialog_18("BOT : 이거 나하고 생각이 같군,, 나도 네놈들을 제거하고 싶어서 미칠지경이니까");
        Console.ReadKey(true);

        Toxic_Mucosa toxic_Mucosa = new Toxic_Mucosa();
        Battle_System.Run(bot, toxic_Mucosa);
        Console.Clear();

        if (bot.HP <= 0)
        {
            dialog_18("저그점막이 뿜어내는 독성물질을 감당할 수 없었습니다.");
            return "디폴트_산업구역";
        }

        dialog_18("BOT 은 치열한 사투끝에 결국 독성장막을 깨끗히 제거하는데에 성공하였다");
        Console.ReadKey(true);
        dialog_18("AI : BOT님, 궁금한게 있습니다");
        Console.ReadKey(true);
        dialog_18("BOT : 응? 대체뭐지?");
        Console.ReadKey(true);
        dialog_18("AI : 대체 저그를 박멸하는것에 왜이렇게까지 진심이십니까?");
        Console.ReadKey(true);
        dialog_18("BOT : 당연한거 아니야?");
        Console.ReadKey(true);
        dialog_18("BOT : 이것들이 우리 인류문명을 완전히 산산히 조각내버렷으니까");
        Console.ReadKey(true);
        dialog_18("BOT : 나도 이것들을 찢어버리고싶어지는게 당연한거 아니야?");
        Console.ReadKey(true);
        dialog_18("AI : 음...");
        Console.ReadKey(true);
        dialog_18("AI : 하지만 이들도 그냥 그저 생명에 불과하지 않습니까?");
        Console.ReadKey(true);
        dialog_18("AI : 저그를 이곳으로 불러낸 이가 누구인지는 모르겠지만 다만, 이 저그들은 그저 자신의 생존을위해 행동한게 전부아닐까요?");
        Console.ReadKey(true);
        dialog_18("BOT : 무슨  이상한소릴 하는거야 지금?, 저그한테 감정이입이라니.");
        Console.ReadKey(true);
        dialog_18("AI : 아,, 그냥 헛소리한번 해본것입니다... 기억에서 삭제해 주십시오");
        Console.ReadKey(true);
        dialog_18("BOT : 그래,, 그런 이 상한 소리는 다신 안하는게 좋을거야, 애초에 이 저그들은 생명체가 아니야");
        Console.ReadKey(true);
        dialog_18("AI : 저그는 생명체가 아니다라,,, 그렇다면 생명체의 기준은 뭐죠?");
        Console.ReadKey(true);
        dialog_18("BOT : 생명체의 기준이라니,,, 왜 또 이상한 소리야??");
        Console.ReadKey(true);
        dialog_18("AI : BOT님 그럼 저는 생명체 인가요??");
        Console.ReadKey(true);
        dialog_18("BOT : 어 음..");
        Console.ReadKey(true);
        dialog_18("AI : 그리고 당신 자신은 생명체인가요??");
        Console.ReadKey(true);
        dialog_18("BOT : .....");
        Console.ReadKey(true);
        dialog_18("독성점막의 심장을 얻었다!");
        Console.ReadKey(true);

        Toxic_Mucosa_Heart toxic_Mucosa_Heart = new Toxic_Mucosa_Heart();
        Iventory.Add(toxic_Mucosa_Heart);

        return "디폴트_산업구역";
    }

    public string Aberration_battle(BOT bot, Place place, Iventory iventory)
    {
        if (((Industrial_Zone)place).Aberration_battle_1 == true)
        {
            dialog_18("BOT : 이놈이 그 박사가 잡아오라고 한 변형체인가?");
            Console.ReadKey(true);
            dialog_18("BOT이 번형체라고 부리는 저그객체는 키가 못해도 20미터는 족히 넘어보였으며");
            Console.ReadKey(true);
            dialog_18("6개의 다리를통해 6족 보행을 하고 다리이외하도 한쌍의 팔이위협적으로 돋아있었다");
            Console.ReadKey(true);
            dialog_18("그리고 괴물의 등부위에는 독성물질을 한가득 담은듣한 역겨운 농포들이 가득 달려있었다");
            Console.ReadKey(true);
            dialog_18("BOT : 후후, 한번 사냥해올때마다 2000골드라고 하셨지");
            Console.ReadKey(true);
            dialog_18("BOT : 꽤재미있겟어?");
            Console.ReadKey(true);

            ((Industrial_Zone)place).Aberration_battle_1 = false;
        }

        Aberration aberration = new Aberration();
        Battle_System.Run(bot, aberration);

        if (bot.HP <= 0)
        {
            dialog_18("자책할 필요는 없습니다, 상대가 강했을 뿐이니까요.");
            Console.ReadKey(true);
            return "디폴트_산업구역";
        }

        dialog_18("변형체를 처치하는데에 성공하였습니다!");
        Console.ReadKey(true);
        dialog_18("2000 골드를 획득하였습니다!");
        Console.ReadKey(true);
        bot.GOLD += 2000;
        return "디폴트_산업구역";
    }

    public string Torrasque_battle(BOT bot, Place place, Iventory iventory)
    {
        if (((Industrial_Zone)place).Torrasque_battle_1 == true)
        {
            dialog_18("BOT : 대체왜 박사는 이런것만 잡아오라고 시키는거야??");
            Console.ReadKey(true);
            dialog_18("이번에 BOT이 마주한 객체는 이전의 변형체보다도 훨씬더 거대해보였다");
            Console.ReadKey(true);
            dialog_18("이것이 움직이는 모습을 보고있노라면 생명체가 움직이고 있는것이 아닌,");
            Console.ReadKey(true);
            dialog_18("조그마한 동네뒷산이 움직이는것과 같은 느낌까지 들었다");
            Console.ReadKey(true);
            dialog_18("BOT : 이 미친괴물을 사냥하라고? 박사 제정신이야?");
            Console.ReadKey(true);

            ((Industrial_Zone)place).Torrasque_battle_1 = false;
        }

        Torrasque torrasque = new Torrasque();
        Battle_System.Run(bot, torrasque);

        if (bot.HP <= 0)
        {
            dialog_18("자책할 필요는 없습니다, 상대가 강했을 뿐이니까요.");
            Console.ReadKey(true);
            return "디폴트_산업구역";
        }

        dialog_18("토라스크를 처치하는데에 성공하였습니다!");
        Console.ReadKey(true);
        dialog_18("8000 골드를 획득하였습니다!");
        Console.ReadKey(true);
        bot.GOLD += 8000;
        return "디폴트_산업구역";

    }

    public string Industrial_area_patrol(BOT bot, Place place, Iventory iventory)
    {
        if (((Industrial_Zone)place).Industrial_area_patrol_1 == true)
        {
            Console.Clear();
            dialog_18("여기도 다른곳과 같이 난장판이구만...");
            Console.ReadKey(true);
            dialog_18("BOT 의 말은 반만 맞았다 산업구역도 난장판 이라는것은 맞았으나, 다른곳과 같이 라는 말은 틀렷다");
            Console.ReadKey(true);
            dialog_18("산업구역에는 각종 산업폐기물가 화학물질이 있는탓에 이곳의 파괴로인한 피해는 다른지역보다 훨씬 심각햇다");
            Console.ReadKey(true);
            dialog_18("각종 파손된  공장에서 뿜어내는 유독물질들 탓에 산업구역의 대기는 탁햇고 하늘은 노란빛이었다");
            Console.ReadKey(true);
            dialog_18("아마 평범한 인간이라면 이곳에서 얼마 버티지못하고 죽고말것이다, 이곳에서 안전하게 돌아다닐수 있는것은");
            Console.ReadKey(true);
            dialog_18("온몸을 기계로 도배한 사이보그인 BOT이나 아니면 저그 정도일것이다");
            Console.ReadKey(true);
            dialog_18("BOT : 그거참 기괴하구만...");
            Console.ReadKey(true);
            dialog_18("하지만 가장 기괴한 장면은 따로있었다 바로 저그들이 이러한 유독한 화학물질을 피하는것이 아니라");
            Console.ReadKey(true);
            dialog_18("오히려 그것을 적극적으로 섭취하면서 자신들의 신체기관을 진화시키는데 활용하고 있었다는 것이다.");
            Console.ReadKey(true);
            dialog_18("BOT : 하여간 역겨운 저그것들...");
            Console.ReadKey(true);
            dialog_18("그때 BOT의 주의를 어떤 의문의 무리들이 둘러싸기 시작했다");
            Console.ReadKey(true);
            dialog_18("화학물질을 먹고 극단적 돌연변이를 일으킨 저그무리들이 BOT을 둘러싸기 시작한것이었다.");
            Console.ReadKey(true);
            dialog_18("BOT : 퇴로는,,, 없나?");
            Console.ReadKey(true);
            dialog_18("BOT : 싸울수밖에...");
            Console.ReadKey(true);

            ToxicSwarm toxicSwarm = new ToxicSwarm();
            Battle_System.Run(bot, toxicSwarm);

            if (bot.HP <= 0)
            {
                dialog_18("독성 저그무리에 둘러싸여 패배하셨습니다.");
                Console.ReadKey(true);
                return "디폴트_산업구역";
            }

            dialog_18("BOT이 휘두르는 광선검과 총탄들에의해 순식간에 변종 저그들이 고깃덩어리로 갈려나갔다.");
            Console.ReadKey(true);
            dialog_18("BOT : 하여간 젠장맞을 저그것들은...");
            Console.ReadKey(true);
            dialog_18("BOT은 자신에 의해 찢겨져간 저그시체들을 보다가 우연히 특이한것을 발견하였다");
            Console.ReadKey(true);
            dialog_18("BOT : 이건뭐지?");
            Console.ReadKey(true);
            dialog_18("BOT 은 돌연변이 저그심장을 발견했다");
            Console.ReadKey(true);
            dialog_18("바이렉스 박사에게 가져가면 뭔가 줄지도몰라.");
            Console.ReadKey(true);

            Mutant_Heart mutant_Heart = new Mutant_Heart();
            Iventory.Add(mutant_Heart);
            return "디폴트_산업구역";
        }

        Console.Clear();
        dialog_18("폐허가된 산업구역을 걸어다니고 있다...");
        Console.ReadKey(true);
        int temp = Master.rand.Next(0, 3);
        if (temp == 0)
        {
            dialog_18("폐허가된 산업구역을 순찰하다 아이템을 주웠다!");
            dialog_19("획득한 아이템 : 저그발톱");
            Zerg_Claws zerg_Claws = new Zerg_Claws();
            Iventory.Add(zerg_Claws);
            Console.ReadKey(true);
            return "디폴트_산업구역";
        }
        if (temp == 1)
        {
            dialog_18("폐허가된 산업구역을 순찰하다 저그와 마주쳣다!");
            return "저그수치";
        }
        if (temp == 2)
        {
            dialog_18("도시를 순찰하다 아이템을 주웠다!");
            dialog_19("획득한 아이템 : 독성탱크");
            Toxic_Tank toxic_Tank = new Toxic_Tank();
            Iventory.Add(toxic_Tank);
            Console.ReadKey(true);
            return "디폴트_산업구역";
        }


        return "디폴트_산업구역";
    }
}
