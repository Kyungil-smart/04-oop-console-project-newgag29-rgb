public partial class All_Stroy
{
    public string Industrial_Default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("파괴된 산업시설에서 쏟아져나오는 산업폐기물가 독가스는 인체에 치명적이였으나,");
        Console.WriteLine("몇몇 저그종들은 그것에 적응하여 오히려 그것을 식량으로 사용하는것같다.");
        Console.WriteLine("1. 파괴된 산업구역을 순찰한다");
        Console.WriteLine("2. 폐공장 내부로 진입한다");
        Console.WriteLine("3. 파괴된 산업구역에 있는 저그를 수색 섬멸한다.");
        Console.WriteLine("4. 변형체와 조우한다");
        Console.WriteLine("5. 토라스크와 조우한다.");
        Console.WriteLine("6. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "산업구역순찰";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "폐공장";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "저그수치";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "변형체";
            }
            if ((int)key.KeyChar - '0' == 5)
            {
                return "토라스크";
            }
            if ((int)key.KeyChar - '0' == 6)
            {
                return "나가기";
            }
        }
    }
}
