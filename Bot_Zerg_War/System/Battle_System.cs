public class Battle_System
{

    public static void dialog_15(string sentence)
    {
        Console.SetCursorPosition(0, 15);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 15);
        Console.WriteLine($"{sentence}");
    }

    public static void dialog_13(string sentence)
    {
        Console.SetCursorPosition(0, 13);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 13);
        Console.WriteLine($"{sentence}");
    }

    public static void dialog_12(string sentence)
    {
        Console.SetCursorPosition(0, 12);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 12);
        Console.WriteLine($"{sentence}");
    }

    static bool DEF_UP = false;

    public static void Run(BOT bot, Zerg zerg)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"{zerg.Name} 과의 전투가 시작되었습니다!");
        zerg.Print();

        while (true)
        {
            dialog_12($"BOT의 남은 체력 {bot.HP}/{bot.MAX_HP}");
            dialog_13($"{zerg.Name}의 남은 체력 {zerg.HP}/{zerg.MAX_HP}");

            while (true)
            {
                dialog_15("1. 공격 / 2. 방어 / 3. 도주");

                ConsoleKeyInfo key = Console.ReadKey(true);
                if ((int)key.KeyChar - '0' == 1)
                {
                    dialog_15($"공격이 적중했습니다 데미지 : {bot.ATK - zerg.DEF} ");
                    zerg.HP -= bot.ATK - zerg.DEF;
                    Console.ReadKey(true);
                    break;
                }
                if ((int)key.KeyChar - '0' == 2)
                {
                    dialog_15($"방어태세에 돌입합니다 당신의 방어력이 2배 증가합니다. ");
                    DEF_UP = true;
                    Console.ReadKey(true);
                    break;
                }
                if ((int)key.KeyChar - '0' == 3)
                {
                    dialog_15("도주를 선택하셨습니다...  겁쟁이....");
                    Console.ReadKey(true);
                    return;
                }
            }

            if (zerg.HP <= 0)
            {
                dialog_15("축하합니다 혐오스러운 저그를 물리치셨습니다");
                Console.ReadKey(true);
                return;
            }

            if (DEF_UP == true)
            {
                dialog_15($"{zerg.Name} 로부터 {zerg.ATK - bot.DEF * 2}의 데미지를 받았습니다");
                bot.HP -= zerg.ATK - bot.DEF * 2;
                DEF_UP = false;
                Console.ReadKey(true);
            }
            else
            {
                dialog_15($"{zerg.Name} 로부터 {zerg.ATK - bot.DEF}의 데미지를 받았습니다");
                bot.HP -= zerg.ATK - bot.DEF;
                Console.ReadKey(true);
            }

            if (bot.HP <= 0)
            {
                dialog_15("전투불능 상태까지 기체가 훼손되었습니다 메인터넌스베이에서 부활합니다");
                Console.ReadKey(true);
                return;
            }
        }
    }
}