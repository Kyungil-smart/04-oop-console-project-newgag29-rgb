public partial class All_Stroy
{
    public string Infested_District_Default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("한때 번화가였던 이곳은 완전히 저그에 감염된 이후이다, 모든시설, 모든건물이 저그의 점막으로 뒤덮혀있다");
        Console.WriteLine("이정도로 높은 저그수치는 처음본다...");
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 감염된 거리를 순찰한다");
        Console.WriteLine("2. 감염된 거리에 있는 저그를 수색 섬멸한다");
        Console.WriteLine("3. 감염된 거리내에있는 특수괴물들과 조우한다.");
        Console.WriteLine("4. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "감염된거리순찰";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "저그수치";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "특수저그";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "나가기";
            }
        }
    }
}
