public partial class All_Stroy
{
    public string Bridge_default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("이곳은 과거 다른 도시로 건너가기위한 고속도로였으나,");
        Console.WriteLine("저그 침공이후 완전히 끊어져 교통수단으로써의 기능을 상실하였다.");
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 붕괴된 다리를 순찰한다");
        Console.WriteLine("2. 붕괴된 다리에있는 저그를 수색 섬멸한다.");
        Console.WriteLine("3. 부르탈리스크 와의 전투");
        Console.WriteLine("4. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "도시순찰";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "저그수치";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "부르탈리스크";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "나가기";
            }
        }
    }
}
