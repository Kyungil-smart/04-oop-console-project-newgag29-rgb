class GameMaster
{
    public static bool IsGameOver { get; set; }

    public void Run()
    {
        All_Stroy all_Stroy = new();
        ADJ_Graph.init(10);
        matching.matching_();
        BOT bot = new BOT();
        Battle_System battle_System = new Battle_System();
        Iventory iventory = new Iventory();
        iventory._bot = bot;
        Initialization._init_(Ruler.placemap_E_P, Ruler.placemap_P_E, all_Stroy, iventory);
        bot.CurPos = 0;

        while (!IsGameOver)
        {
            Ruler.placemap_E_P[(PLACE_ENUM)bot.CurPos].Place_Master(bot, all_Stroy, iventory);
        }
    }
}

static public class Master
{
    public static Random rand = new Random();
}