public partial class All_Stroy
{
    //===============================================================아래 저그수치 0이상=======================================================================
    public string Battle_Zergling(BOT bot, Place place, Iventory iventory)
    {
        Zergling zergling = new Zergling();
        Battle_System.Run(bot, zergling);

        if (bot.HP <= 0)
        {
            bot.CurPos = 0;
        }

        if (place is City_Streets)
        {
            return
        }
        if (place is Abandoned_Subway_Station)
        {

        }
        if (place is Industrial_Zone)
        {

        }
        if (place is Infested_District)
        {

        }
        if (place is Zerg_Nest)
        {

        }
        if (place is Blacksite)
        {

        }
        if (place is Skyway)
        {

        }
        if (place is Collapsed_Bridge)
        {

        }
        if (place is SmartCity_ControlGrid)
        {

        }
    }

    public string Battle_Raptor(BOT bot, Place place, Iventory iventory)
    {
        Raptor raptor = new Raptor();
        Battle_System.Run(bot, raptor);

        return "도시디폴트";
    }

    public string Battle_Roach(BOT bot, Place place, Iventory iventory)
    {
        Roach roach = new Roach();
        Battle_System.Run(bot, roach);

        return "도시디폴트";
    }

    public string Battle_Ravager(BOT bot, Place place, Iventory iventory)
    {
        Ravager ravager = new Ravager();
        Battle_System.Run(bot, ravager);

        return "도시디폴트";
    }

    //===============================================================아래 저그수치 10이상======================================================================

    public string Battle_Mutalisk(BOT bot, Place place, Iventory iventory)
    {
        Mutalisk mutalisk = new Mutalisk();
        Battle_System.Run(bot, mutalisk);

        return "도시디폴트";
    }

    public string Battle_Scourge(BOT bot, Place place, Iventory iventory)
    {
        Scourge scourge = new Scourge();
        Battle_System.Run(bot, scourge);

        return "도시디폴트";
    }

    public string Battle_Hydralisk(BOT bot, Place place, Iventory iventory)
    {
        Hydralisk hydralisk = new Hydralisk();
        Battle_System.Run(bot, hydralisk);

        return "도시디폴트";
    }

    //===============================================================아래 저그수치 20이상======================================================================

    public string Battle_Giant_Roach(BOT bot, Place place, Iventory iventory)
    {
        Giant_Roach giant_Roach = new Giant_Roach();
        Battle_System.Run(bot, giant_Roach);

        return "도시디폴트";
    }

    public string Battle_Spore_Crawler(BOT bot, Place place, Iventory iventory)
    {
        Spore_Crawler spore_Crawler = new Spore_Crawler();
        Battle_System.Run(bot, spore_Crawler);

        return "도시디폴트";
    }

    public string Battle_Spine_Crawler(BOT bot, Place place, Iventory iventory)
    {
        Spine_Crawler spine_Crawler = new Spine_Crawler();
        Battle_System.Run(bot, spine_Crawler);

        return "도시디폴트";
    }

    public string Battle_Raptor_Pack(BOT bot, Place place, Iventory iventory)
    {
        Raptor_Pack raptor_Pack = new Raptor_Pack();
        Battle_System.Run(bot, raptor_Pack);

        return "도시디폴트";
    }

    //===============================================================아래 저그수치 30이상======================================================================

    public string Battle_Venom_Bug(BOT bot, Place place, Iventory iventory)
    {
        Venom_Bug venom_Bug = new Venom_Bug();
        Battle_System.Run(bot, venom_Bug);

        return "도시디폴트";
    }

    public string Battle_Lurker(BOT bot, Place place, Iventory iventory)
    {
        Lurker lurker = new Lurker();
        Battle_System.Run(bot, lurker);

        return "도시디폴트";
    }

    public string Battle_Mutant_Hydralisk(BOT bot, Place place, Iventory iventory)
    {
        Mutant_Hydralisk mutant_Hydralisk = new Mutant_Hydralisk();
        Battle_System.Run(bot, mutant_Hydralisk);

        return "도시디폴트";
    }

    //===============================================================아래 저그수치 40이상======================================================================

    public string Battle_Guardian(BOT bot, Place place, Iventory iventory)
    {
        Guardian guardian = new Guardian();
        Battle_System.Run(bot, guardian);

        return "도시디폴트";
    }

    public string Battle_Devourer(BOT bot, Place place, Iventory iventory)
    {
        Devourer devourer = new Devourer();
        Battle_System.Run(bot, devourer);

        return "도시디폴트";
    }

    public string Battle_Viper(BOT bot, Place place, Iventory iventory)
    {
        Viper viper = new Viper();
        Battle_System.Run(bot, viper);

        return "도시디폴트";
    }
}