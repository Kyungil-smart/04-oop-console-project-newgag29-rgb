public partial class All_Stroy
{
    public string Skyway_default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("저그의 침공으로인해 쑥대밭이된 다른 지역에 비해 비교적 본래의 기능을 다하고있는 구역이다.");
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 스카이웨이를 순찰한다");
        Console.WriteLine("2. 스카이웨이에 있는 저그를 수색 섬멸한다.");
        Console.WriteLine("3. 스카이웨이 교통종합 센터를 방문한다");
        Console.WriteLine("4. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "스카이웨이순찰";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "저그수치";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "교통종합센터";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "나가기";
            }
        }
    }
}
