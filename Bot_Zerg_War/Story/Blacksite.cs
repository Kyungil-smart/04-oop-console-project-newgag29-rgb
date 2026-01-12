public partial class All_Stroy
{
    public string Blacksite_Default(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine($"당신은 현재위치 {place.Place_name}");
        Console.WriteLine("비공개 구역에서는 의문의 세력의 지원을 받는 첨단장비로 무장한 용병들과");
        Console.WriteLine("저그를 대상으로한 각종 신기하고 독창적인 생체실험이 벌어지고 있었다.");
        Console.WriteLine("1. 비공개 구역 직원과 대화한다");
        Console.WriteLine("2. 시설 관리자의 방에간다.");
        Console.WriteLine("3. 저그 샘플을 제공한다.");
        Console.WriteLine("4. ???");
        Console.WriteLine("5. 다른장소로 이동한다.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if ((int)key.KeyChar - '0' == 1)
            {
                return "비공개직원";
            }
            if ((int)key.KeyChar - '0' == 2)
            {
                return "비공개관리자";
            }
            if ((int)key.KeyChar - '0' == 3)
            {
                return "저그샘플";
            }
            if ((int)key.KeyChar - '0' == 4)
            {
                return "???";
            }
            if ((int)key.KeyChar - '0' == 5)
            {
                return "나가기";
            }
        }
    }
}

