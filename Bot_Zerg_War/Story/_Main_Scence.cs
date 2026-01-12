public partial class All_Stroy
{
    public delegate string stroy_del(BOT bot, Place place, Iventory iventory);

    public string Location_Out(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Dictionary<int, int> place_selection = new Dictionary<int, int>();
        Console.WriteLine($"현재 당신의 위치는 : {Ruler.placemap_E_P[(PLACE_ENUM)bot.CurPos].Place_name} ");
        Dictionary<int, Place> selct_num = new Dictionary<int, Place>();
        Console.Write($"당신이 이동할 수 있는 위치는 : ");
        foreach (var x in ADJ_Graph.adjList[bot.CurPos])
        {
            Console.Write($"[{Ruler.placemap_E_P[(PLACE_ENUM)x].Place_name}]");
        }

        for (int i = 0; i < ADJ_Graph.adjList[bot.CurPos].Count; i++)
        {
            place_selection.Add(i + 1, ADJ_Graph.adjList[bot.CurPos][i]);
        }

        Console.WriteLine();
        Console.Write("어느 위치로 이동시겠습니까? (숫자를 타이핑하시오 예: 1,2,3,4...) : ");
        for (int i = 0; i < ADJ_Graph.adjList[bot.CurPos].Count; i++)
        {
            Console.WriteLine();
            Console.Write($"{i + 1}번 -{Ruler.placemap_E_P[(PLACE_ENUM)ADJ_Graph.adjList[bot.CurPos][i]].Place_name}-");
            selct_num.Add(i + 1, Ruler.placemap_E_P[(PLACE_ENUM)ADJ_Graph.adjList[bot.CurPos][i]]);
        }
        Console.WriteLine();

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (selct_num.Any(x => x.Key == (int)key.KeyChar - '0'))
            {
                bot.CurPos = place_selection[(int)key.KeyChar - '0'];
                break;
            }
        }

        return "의미없음";
    }

    public string Resurrection(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Dictionary<int, int> place_selection = new Dictionary<int, int>();
        Console.WriteLine($"현재 당신의 위치는 : {Ruler.placemap_E_P[(PLACE_ENUM)bot.CurPos].Place_name} ");
        Dictionary<int, Place> selct_num = new Dictionary<int, Place>();
        Console.Write($"당신이 이동할 수 있는 위치는 : ");
        foreach (var x in ADJ_Graph.adjList[bot.CurPos])
        {
            Console.Write($"[{Ruler.placemap_E_P[(PLACE_ENUM)x].Place_name}]");
        }

        for (int i = 0; i < ADJ_Graph.adjList[bot.CurPos].Count; i++)
        {
            place_selection.Add(i + 1, ADJ_Graph.adjList[bot.CurPos][i]);
        }

        Console.WriteLine();
        Console.Write("어느 위치로 이동시겠습니까? (숫자를 타이핑하시오 예: 1,2,3,4...) : ");
        for (int i = 0; i < ADJ_Graph.adjList[bot.CurPos].Count; i++)
        {
            Console.WriteLine();
            Console.Write($"{i + 1}번 -{Ruler.placemap_E_P[(PLACE_ENUM)ADJ_Graph.adjList[bot.CurPos][i]].Place_name}-");
            selct_num.Add(i + 1, Ruler.placemap_E_P[(PLACE_ENUM)ADJ_Graph.adjList[bot.CurPos][i]]);
        }
        Console.WriteLine();

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (selct_num.Any(x => x.Key == (int)key.KeyChar - '0'))
            {
                bot.CurPos = place_selection[(int)key.KeyChar - '0'];
                break;
            }
        }

        return "의미없음";
    }

    public void dialog_18(string sentence)
    {
        Console.SetCursorPosition(0, 18);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 18);
        Console.WriteLine($"{sentence}");
    }

    public void dialog_19(string sentence)
    {
        Console.SetCursorPosition(0, 19);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 19);
        Console.WriteLine($"{sentence}");
    }

    public void dialog_15(string sentence)
    {
        Console.SetCursorPosition(0, 15);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 15);
        Console.WriteLine($"{sentence}");
    }

    public void dialog_22(string sentence)
    {
        Console.SetCursorPosition(0, 22);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 22);
        Console.WriteLine($"{sentence}");
    }

    public void dialog_23(string sentence)
    {
        Console.SetCursorPosition(0, 23);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 23);
        Console.WriteLine($"{sentence}");
    }

    public void dialog_24(string sentence)
    {
        Console.SetCursorPosition(0, 24);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 24);
        Console.WriteLine($"{sentence}");
    }


    public void Print_BYREX()
    {
        Console.WriteLine(@"
            .-''''-.
          .'  _  _  '.
         /   (o)(o)   \
        |      __      |
        |   .-'__'-.   |
         \  \  --  /  /
          '. '----' .'
            '-.__.-'
             /|  |\ 
            /_|__|_\
          _/  ||||  \_
         /_   ||||   _\
           '._||||_.'
              ||||
              ||||
          ____||||____
         /____BYREX___\
");

    }

    public string Zerg_Level_Check(BOT bot, Place place, Iventory iventory)
    {
        if (0 <= place.zergLevel && place.zergLevel < 10) 
        {
            int temp = Master.rand.Next(0, 3);
            if (temp == 0)
            {
                return "저글링";
            }
            if (temp == 1)
            {
                return "랩터";
            }
            if (temp == 2)
            {
                return "바퀴";
            }
            if (temp == 3)
            {
                return "궤멸충";
            }
        }
        if (10 <= place.zergLevel && place.zergLevel < 20)
        {
            int temp = Master.rand.Next(0, 2);
            if (temp == 0)
            {
                return "뮤탈리스크";
            }
            if (temp == 1)
            {
                return "스커지";
            }
            if (temp == 2)
            {
                return "히드라리스크";
            }
        }
        if (20 <= place.zergLevel && place.zergLevel < 30)
        {
            int temp = Master.rand.Next(0, 3);
            if (temp == 0)
            {
                return "거대바퀴";
            }
            if (temp == 1)
            {
                return "포자촉수";
            }
            if (temp == 2)
            {
                return "가시촉수";
            }
            if (temp == 3)
            {
                return "랩터무리";
            }
        }
        if (30 <= place.zergLevel && place.zergLevel < 40)
        {
            int temp = Master.rand.Next(0, 2);
            if (temp == 0)
            {
                return "폭독충";
            }
            if (temp == 1)
            {
                return "가시지옥";
            }
            if (temp == 2)
            {
                return "돌연변이_거대히드라";
            }
        }
        if (40 <= place.zergLevel && place.zergLevel < 50)
        {
            int temp = Master.rand.Next(0, 2);
            if (temp == 0)
            {
                return "수호군주";
            }
            if (temp == 1)
            {
                return "포식군주";
            }
            if (temp == 2)
            {
                return "살모사";
            }
        }


        return "의미없음";
    }
}