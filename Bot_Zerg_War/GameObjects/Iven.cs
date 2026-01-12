public class Iventory
{
    private static ItemSlot[,] Iven_Slot = new ItemSlot[7, 7];
    static Vector Click_idx;
    public BOT _bot;

    public Iventory()
    {
        for (int y = 0; y < 7; y++)
        {
            for (int x = 0; x < 7; x++)
            {
                Vector pos = new Vector(x, y);
                Iven_Slot[y, x] = new ItemSlot(pos);
            }
        }
    }
    public static void Render()
    {

        Console.WriteLine(" 인벤토리창 입니다 : 종료하려면 (Q)");

        for (int y = 0; y < Iven_Slot.GetLength(0); y++)
        {
            for (int x = 0; x < Iven_Slot.GetLength(1); x++)
            {
                if (Iven_Slot[y, x].Position == Click_idx)
                {
                    Console.Write($"[☆ ]");
                }
                else
                {
                    Console.Write("[");
                    Iven_Slot[y, x].Print();
                    Console.Write("]");
                }
            }
            Console.WriteLine();
        }
        int a = Click_idx.X;
        int b = Click_idx.Y;

        if (Iven_Slot[b, a].OnTileItem != null)
        {
            Console.WriteLine($"현재 선택중인 장비 : {Iven_Slot[b, a].OnTileItem.Name}");
            Console.WriteLine($"{Iven_Slot[b, a].OnTileItem.Description}");
        }
        else
        {
            Console.WriteLine($"현재 선택중인 장비 : 없음");
            Console.WriteLine($"아이템 타입 : 없음");
            Console.WriteLine($"설명 없음");
        }
    }

    public static void Iven_Search()
    {
        Console.Clear();
        Click_idx = new Vector(0, 0);

        while (true)
        {
            Console.Clear();
            Render();
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.W && Click_idx.Y > 0)
            {
                Click_idx = Click_idx + new Vector(0, -1);
            }
            if (key.Key == ConsoleKey.A && Click_idx.X > 0)
            {
                Click_idx = Click_idx + new Vector(-1, 0);
            }
            if (key.Key == ConsoleKey.S && Click_idx.Y < 6)
            {
                Click_idx = Click_idx + new Vector(0, 1);
            }
            if (key.Key == ConsoleKey.D && Click_idx.X < 6)
            {
                Click_idx = Click_idx + new Vector(1, 0);
            }
            if (key.Key == ConsoleKey.Q)
            {
                return;
            }
        }
    }

    public static void Iven_Replacement(BOT bot, Iventory iventory, int idx)
    {
        Console.Clear();
        Console.Write(" 자네가 교체하고 싶은 장비로 고르게..");
        Click_idx = new Vector(0, 0);

        while (true)
        {
            Console.Clear();
            int a = Click_idx.X;
            int b = Click_idx.Y;
            Render_W();
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.W && Click_idx.Y > 0)
            {
                Click_idx = Click_idx + new Vector(0, -1);
            }
            if (key.Key == ConsoleKey.A && Click_idx.X > 0)
            {
                Click_idx = Click_idx + new Vector(-1, 0);
            }
            if (key.Key == ConsoleKey.S && Click_idx.Y < 6)
            {
                Click_idx = Click_idx + new Vector(0, 1);
            }
            if (key.Key == ConsoleKey.D && Click_idx.X < 6)
            {
                Click_idx = Click_idx + new Vector(1, 0);
            }
            if (key.Key == ConsoleKey.Q)
            {
                return;
            }
            if (key.Key == ConsoleKey.E && Iven_Slot[b, a].OnTileItem != null)
            {
                bot.equipped_Weapon[idx] = Iven_Slot[b, a].OnTileItem;
                Iven_Slot[b, a].OnTileItem = null;
                return;
            }
        }
    }

    public static void Render_W()
    {

        Console.WriteLine("자네가 교체하고 싶은 장비로 고르게..");
        Console.WriteLine("교체하고 싶은 장비 선택후 -> E");
        Console.WriteLine("종료를 원하면 -> Q");

        for (int y = 0; y < Iven_Slot.GetLength(0); y++)
        {
            for (int x = 0; x < Iven_Slot.GetLength(1); x++)
            {
                if (Iven_Slot[y, x].Position == Click_idx)
                {
                    Console.Write($"[☆ ]");
                }
                else
                {
                    Console.Write("[");
                    Iven_Slot[y, x].Print();
                    Console.Write("]");
                }
            }
            Console.WriteLine();
        }
        int a = Click_idx.X;
        int b = Click_idx.Y;

        if (Iven_Slot[b, a].OnTileItem != null)
        {
            Console.WriteLine($"현재 선택중인 장비 : {Iven_Slot[b, a].OnTileItem.Name}");
            Console.WriteLine($"{Iven_Slot[b, a].OnTileItem.Description}");
        }
        else
        {
            Console.WriteLine($"현재 선택중인 장비 : 없음");
            Console.WriteLine($"아이템 타입 : 없음");
            Console.WriteLine($"설명 없음");
        }
    }





    public static void Add(Item item)
    {
        for (int y = 0; y < Iven_Slot.GetLength(0); y++)
        {
            for (int x = 0; x < Iven_Slot.GetLength(1); x++)
            {
                if (Iven_Slot[y, x].OnTileItem == null)
                {
                    Iven_Slot[y, x].OnTileItem = item;
                    return;
                }
            }
        }
    }
}

public struct ItemSlot
{
    public Vector Position { get; set; }
    public Item? OnTileItem { get; set; }
    public bool HasItem => OnTileItem != null;

    public ItemSlot(Vector position)
    {
        Position = position;
        OnTileItem = null;
    }

    public void Print()
    {
        if (HasItem)
        {
            Console.Write(OnTileItem.Symbol);
        }
        else
        {
            Console.Write(' ');
        }
    }
}