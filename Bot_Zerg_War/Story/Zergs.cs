public partial class All_Stroy
{
    //===============================================================아래 저그수치 0이상=======================================================================
    public string Battle_Zergling(BOT bot, Place place, Iventory iventory)
    {
        Zergling zergling = new Zergling();
        Battle_System.Run(bot, zergling);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Raptor(BOT bot, Place place, Iventory iventory)
    {
        Raptor raptor = new Raptor();
        Battle_System.Run(bot, raptor);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Roach(BOT bot, Place place, Iventory iventory)
    {
        Roach roach = new Roach();
        Battle_System.Run(bot, roach);

        

        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Ravager(BOT bot, Place place, Iventory iventory)
    {
        Ravager ravager = new Ravager();
        Battle_System.Run(bot, ravager);

        

        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    //===============================================================아래 저그수치 10이상======================================================================

    public string Battle_Mutalisk(BOT bot, Place place, Iventory iventory)
    {
        Mutalisk mutalisk = new Mutalisk();
        Battle_System.Run(bot, mutalisk);


        if (bot.HP <= 0)
        {
            return "의미없음";
        }
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음"; 
    }

    public string Battle_Scourge(BOT bot, Place place, Iventory iventory)
    {
        Scourge scourge = new Scourge();
        Battle_System.Run(bot, scourge);

        if (bot.HP <= 0)
        {
            return "의미없음";
        }
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Hydralisk(BOT bot, Place place, Iventory iventory)
    {
        Hydralisk hydralisk = new Hydralisk();
        Battle_System.Run(bot, hydralisk);


        if (bot.HP <= 0)
        {
            return "의미없음";
        }
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    //===============================================================아래 저그수치 20이상======================================================================

    public string Battle_Giant_Roach(BOT bot, Place place, Iventory iventory)
    {
        Giant_Roach giant_Roach = new Giant_Roach();
        Battle_System.Run(bot, giant_Roach);


        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Spore_Crawler(BOT bot, Place place, Iventory iventory)
    {
        Spore_Crawler spore_Crawler = new Spore_Crawler();
        Battle_System.Run(bot, spore_Crawler);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Spine_Crawler(BOT bot, Place place, Iventory iventory)
    {
        Spine_Crawler spine_Crawler = new Spine_Crawler();
        Battle_System.Run(bot, spine_Crawler);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Raptor_Pack(BOT bot, Place place, Iventory iventory)
    {
        Raptor_Pack raptor_Pack = new Raptor_Pack();
        Battle_System.Run(bot, raptor_Pack);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    //===============================================================아래 저그수치 30이상======================================================================

    public string Battle_Venom_Bug(BOT bot, Place place, Iventory iventory)
    {
        Venom_Bug venom_Bug = new Venom_Bug();
        Battle_System.Run(bot, venom_Bug);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Lurker(BOT bot, Place place, Iventory iventory)
    {
        Lurker lurker = new Lurker();
        Battle_System.Run(bot, lurker);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Mutant_Hydralisk(BOT bot, Place place, Iventory iventory)
    {
        Mutant_Hydralisk mutant_Hydralisk = new Mutant_Hydralisk();
        Battle_System.Run(bot, mutant_Hydralisk);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    //===============================================================아래 저그수치 40이상======================================================================

    public string Battle_Guardian(BOT bot, Place place, Iventory iventory)
    {
        Guardian guardian = new Guardian();
        Battle_System.Run(bot, guardian);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Devourer(BOT bot, Place place, Iventory iventory)
    {
        Devourer devourer = new Devourer();
        Battle_System.Run(bot, devourer);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

    public string Battle_Viper(BOT bot, Place place, Iventory iventory)
    {
        Viper viper = new Viper();
        Battle_System.Run(bot, viper);

        
        if (place is City_Streets)
        {
            return "디폴트_도시거리";
        }
        if (place is Abandoned_Subway_Station)
        {
            return "디폴트_지하철";
        }
        if (place is Industrial_Zone)
        {
            return "디폴트_산업구역";
        }
        if (place is Infested_District)
        {
            return "디폴트_감염된거리";
        }
        if (place is Zerg_Nest)
        {
            return "디폴트_저그둥지";
        }
        if (place is Blacksite)
        {
            return "디폴트_비공개구역";
        }
        if (place is Skyway)
        {
            return "디폴트_스카이웨이";
        }
        if (place is Collapsed_Bridge)
        {
            return "디폴트_붕괴된다리";
        }
        if (place is SmartCity_ControlGrid)
        {
            return "디폴트_스마트그리드";
        }

        return "의미없음";
    }

   
}