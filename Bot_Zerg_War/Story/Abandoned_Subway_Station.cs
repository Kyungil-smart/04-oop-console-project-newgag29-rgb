public partial class All_Stroy
{
    public string First_Subway(BOT bot, Place place, Iventory iventory)
    {
        Console.Clear();
        Console.WriteLine(@"
      =========================  
  |  |==================|  |
  |  ||  []  []  []    ||  |
  |  ||                ||  |
__|__||________________||__|__

");

        dialog_18("저그 침공전 매일 다니던 지하철 역으로 들어왔다.");
        Console.ReadKey(true);
        dialog_18("역시나 예상했던대로 예전에 알고있던 지하철역은 흔적도 없이 사라졌다.");
        Console.ReadKey(true);
        dialog_18("그자리를 메꾸고 있는건 파괴된 잔해, 사람들의 시체 그리고....");
        Console.ReadKey(true);
        dialog_18("가끔가다 들려오는 저그들의 울음소리들....");
        Console.ReadKey(true);
        dialog_18("그때 갑자기 뒤에서 무언가가 BOT을 급습하였다");
        Console.ReadKey(true);


        return "저그수치";
    }

    public string Subway_Default(BOT bot, Place place, Iventory iventory)
    {
        return "일단";
    }
}
