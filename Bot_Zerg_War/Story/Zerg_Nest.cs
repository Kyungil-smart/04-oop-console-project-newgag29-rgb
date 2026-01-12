public partial class All_Stroy
{
    public string ZergNest_Default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("지옥.");
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 저그와의 전투");
        Console.WriteLine("2. 저그와의 전투");
        Console.WriteLine("3. 저그와의 전투");
        Console.WriteLine("4. 무리여왕에게 쳐들어간다");
        Console.WriteLine("5. 탈출을 시도한다");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "둥지전투";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "둥지전투";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "둥지전투";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "무리여왕";
            }
            if ((int)key.KeyChar - '0' == 5)
            {
                return "탈출시도";
            }
        }
    }
}