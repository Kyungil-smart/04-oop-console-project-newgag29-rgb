public partial class All_Stroy
{
    public string Smart_Grid_Default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("스마트 그리드는 한때 도시 전체에 전력과 수도,천연가스등을 공급하는곳이었으나");
        Console.WriteLine("현재는 공급망이 완전히 붕괴한 상태이다, 하지만 이곳을 잘만 이용한다면 유용할지도....");
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 스마트그리드를 순찰한다");
        Console.WriteLine("2. 스마트그리드에 있는 사람에게 말을건다");
        Console.WriteLine("3. 스마트그리드에 있는 저그를 수색 섬멸한다.");
        Console.WriteLine("4. 스마트그리드 엔지니어를 찾아간다");
        Console.WriteLine("5. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "그리드순찰";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "그리드시민";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "저그수치";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "그리드엔지니어";
            }
            if ((int)key.KeyChar - '0' == 5)
            {
                return "나가기";
            }
        }
    }
}
