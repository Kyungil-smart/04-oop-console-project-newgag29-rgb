using static System.Runtime.InteropServices.JavaScript.JSType;

public abstract class Place
{
    public string Place_name { get; set; }
    public bool Place_leave = false;
    public abstract int zergLevel { get; set; }

    public Place(string _name, All_Stroy story, Iventory iventory)
    {
        Place_name = _name;
    }

    public abstract void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory);
}

public class Maintenance_Bay : Place
{
    public override int zergLevel { get; set; } = 0;
    string Cur_Func = "첫시작";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();


    public Maintenance_Bay(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("첫시작", story.First_Awakening);
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("디폴트_메인터넌스", story.Maintenance_Bay_Option);
        Story_recorder.Add("인벤토리", story.Iven_Check);
        Story_recorder.Add("장비교체", story.Weapon_Change);
        Story_recorder.Add("바이렉스", story.Virex);
        Story_recorder.Add("1번교체", story.First_Weapon);
        Story_recorder.Add("2번교체", story.Second_Weapon);
        Story_recorder.Add("3번교체", story.Third_Weapon);
        Story_recorder.Add("4번교체", story.Fourth_Weapon);
        Story_recorder.Add("5번교체", story.Fifth_Weapon);
        Story_recorder.Add("6번교체", story.Sixth_Weapon);

    }
    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_메인터넌스";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class City_Streets : Place
{
    public override int zergLevel { get; set; } = 0;
    public bool first_came = true;
    public bool Black_market_first = true;
    public bool Suspicious_Building_first = true;
    public bool Mafia_visit = false;

    string Cur_Func = "거리첫방문";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public City_Streets(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("거리첫방문", story.First_street);
        Story_recorder.Add("디폴트_도시거리", story.street_default);
        Story_recorder.Add("전투_성난군중", story.Battle_angry_mob);
        Story_recorder.Add("도시순찰", story.street_patrol);
        Story_recorder.Add("성난군중전투후", story.after_fightwith_mob);
        Story_recorder.Add("암시장", story.Black_market);
        Story_recorder.Add("암시장_상점", story.Black_market_store);
        Story_recorder.Add("수상한빌딩", story.Suspicious_Building);
        Story_recorder.Add("마피아접선", story.Mafia_contact);


        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);

    }
    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_도시거리";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class Abandoned_Subway_Station : Place
{
    public override int zergLevel { get; set; } = 15;
    public bool secret_shelter_firstcame = true;
    string Cur_Func = "지하철첫방문";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public Abandoned_Subway_Station(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("지하철첫방문", story.First_Subway);
        Story_recorder.Add("디폴트_지하철", story.Subway_Default);
        Story_recorder.Add("물자약탈", story.plunder);
        Story_recorder.Add("비밀쉘터", story.secret_shelter);
        Story_recorder.Add("물자보급", story.supply);

        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);
    }
    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_지하철";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class Industrial_Zone : Place
{
    public override int zergLevel { get; set; } = 0;
    string Cur_Func = "나가기";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public Industrial_Zone(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("디폴트_산업구역", story.Industrial_Default);


        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);
    }
    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_산업구역";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class Infested_District : Place
{
    public override int zergLevel { get; set; } = 0;
    string Cur_Func = "나가기";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public Infested_District(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("디폴트_감염된거리", story.Infested_District_Default);


        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);
    }

    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_감염된거리";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class Zerg_Nest : Place
{
    public override int zergLevel { get; set; } = 0;
    string Cur_Func = "나가기";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public Zerg_Nest(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("디폴트_저그둥지", story.ZergNest_Default);


        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);
    }

    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_저그둥지";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class Blacksite : Place
{
    public override int zergLevel { get; set; } = 0;
    string Cur_Func = "나가기";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public Blacksite(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("디폴트_비공개구역", story.Blacksite_Default);



        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);
    }

    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_비공개구역";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class Skyway : Place
{
    public override int zergLevel { get; set; } = 0;
    string Cur_Func = "나가기";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public Skyway(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("디폴트_스카이웨이", story.Skyway_default);


        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);
    }

    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_스카이웨이";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class Collapsed_Bridge : Place
{
    public override int zergLevel { get; set; } = 0;
    string Cur_Func = "나가기";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public Collapsed_Bridge(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("디폴트_붕괴된다리", story.Bridge_default);


        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);
    }

    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_붕괴된다리";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}

public class SmartCity_ControlGrid : Place
{
    public override int zergLevel { get; set; } = 0;
    string Cur_Func = "나가기";
    Dictionary<string, All_Stroy.stroy_del> Story_recorder = new();

    public SmartCity_ControlGrid(string _name, All_Stroy story, Iventory iventory) : base(_name, story, iventory)
    {
        Story_recorder.Add("나가기", story.Location_Out);
        Story_recorder.Add("디폴트_스마트그리드", story.Smart_Grid_Default);


        //===================================저그수치_체크===================================
        Story_recorder.Add("저그수치", story.Zerg_Level_Check);
        //==================================이하 전투함수들==================================
        Story_recorder.Add("저글링", story.Battle_Zergling);
        Story_recorder.Add("랩터", story.Battle_Raptor);
        Story_recorder.Add("바퀴", story.Battle_Roach);
        Story_recorder.Add("궤멸충", story.Battle_Ravager);
        //===============================이하 저그수치 10이상================================
        Story_recorder.Add("뮤탈리스크", story.Battle_Mutalisk);
        Story_recorder.Add("스커지", story.Battle_Scourge);
        Story_recorder.Add("히드라리스크", story.Battle_Hydralisk);
        //===============================이하 저그수치 20이상================================
        Story_recorder.Add("거대바퀴", story.Battle_Giant_Roach);
        Story_recorder.Add("포자촉수", story.Battle_Spore_Crawler);
        Story_recorder.Add("가시촉수", story.Battle_Spine_Crawler);
        Story_recorder.Add("랩터무리", story.Battle_Raptor_Pack);
        //===============================이하 저그수치 30이상================================
        Story_recorder.Add("폭독충", story.Battle_Venom_Bug);
        Story_recorder.Add("가시지옥", story.Battle_Lurker);
        Story_recorder.Add("돌연변이_거대히드라", story.Battle_Mutant_Hydralisk);
        //===============================이하 저그수치 40이상================================
        Story_recorder.Add("수호군주", story.Battle_Guardian);
        Story_recorder.Add("포식군주", story.Battle_Devourer);
        Story_recorder.Add("살모사", story.Battle_Viper);
    }

    public override void Place_Master(BOT bot, All_Stroy Stroy, Iventory iventory)
    {
        Place_leave = false;

        while (!Place_leave)
        {
            string result = Story_recorder[Cur_Func](bot, this, iventory);

            if (result == "의미없음")
            {
                Cur_Func = "디폴트_스마트그리드";
                Place_leave = true;
            }
            else
            {
                Cur_Func = result;
            }
        }
    }
}
