enum PLACE_ENUM
{
    Maintenance_Bay,
    City_Streets,
    Blacksite,
    SmartCity_ControlGrid,
    Abandoned_Subway_Station,
    Industrial_Zone,
    Skyway,
    Infested_District,
    Collapsed_Bridge,
    Zerg_Nest
}

static class Ruler
{
    public static Dictionary<PLACE_ENUM, Place> placemap_E_P;
    public static Dictionary<Place, PLACE_ENUM> placemap_P_E;

    static Ruler()
    {
        placemap_E_P = new Dictionary<PLACE_ENUM, Place>();
        placemap_P_E = new Dictionary<Place, PLACE_ENUM>();
    }
}

static class Initialization
{
    public static void _init_(Dictionary<PLACE_ENUM, Place> placemap_E_P, Dictionary<Place, PLACE_ENUM> placemap_P_E, All_Stroy story, Iventory iventory)
    {
        Maintenance_Bay maintenance_Bay = new("메인터넌스 베이", story, iventory);
        City_Streets city_Streets = new("도시 거리", story, iventory);
        Abandoned_Subway_Station abandoned_Subway_Station = new("버려진 지하철역", story, iventory);
        Industrial_Zone industrial_Zone = new("노후화된 산업구역", story, iventory);
        Infested_District infested_District = new("감염된 거리", story, iventory);
        Zerg_Nest zerg_Nest = new("저그의 둥지", story, iventory);
        Blacksite blacksite = new("비공개 구역", story, iventory);
        Skyway skyway = new("스카이 웨이", story, iventory);
        Collapsed_Bridge collapsed_Bridge = new("붕괴된 다리", story, iventory);
        SmartCity_ControlGrid smartCity_ControlGrid = new("스마트 그리드", story, iventory);

        placemap_E_P.Add(PLACE_ENUM.Maintenance_Bay, maintenance_Bay);
        placemap_E_P.Add(PLACE_ENUM.City_Streets, city_Streets);
        placemap_E_P.Add(PLACE_ENUM.Abandoned_Subway_Station, abandoned_Subway_Station);
        placemap_E_P.Add(PLACE_ENUM.Industrial_Zone, industrial_Zone);
        placemap_E_P.Add(PLACE_ENUM.Infested_District, infested_District);
        placemap_E_P.Add(PLACE_ENUM.Zerg_Nest, zerg_Nest);
        placemap_E_P.Add(PLACE_ENUM.Blacksite, blacksite);
        placemap_E_P.Add(PLACE_ENUM.Skyway, skyway);
        placemap_E_P.Add(PLACE_ENUM.Collapsed_Bridge, collapsed_Bridge);
        placemap_E_P.Add(PLACE_ENUM.SmartCity_ControlGrid, smartCity_ControlGrid);

        placemap_P_E.Add(maintenance_Bay, PLACE_ENUM.Maintenance_Bay);
        placemap_P_E.Add(city_Streets, PLACE_ENUM.City_Streets);
        placemap_P_E.Add(abandoned_Subway_Station, PLACE_ENUM.Abandoned_Subway_Station);
        placemap_P_E.Add(industrial_Zone, PLACE_ENUM.Industrial_Zone);
        placemap_P_E.Add(infested_District, PLACE_ENUM.Infested_District);
        placemap_P_E.Add(zerg_Nest, PLACE_ENUM.Zerg_Nest);
        placemap_P_E.Add(blacksite, PLACE_ENUM.Blacksite);
        placemap_P_E.Add(skyway, PLACE_ENUM.Skyway);
        placemap_P_E.Add(collapsed_Bridge, PLACE_ENUM.Collapsed_Bridge);
        placemap_P_E.Add(smartCity_ControlGrid, PLACE_ENUM.SmartCity_ControlGrid);
    }
}

static class ADJ_Graph
{
    public static List<int>[] adjList { get; set; }

    public static void init(int vertextCount)
    {
        adjList = new List<int>[vertextCount];
        for (int i = 0; i < vertextCount; i++)
        {
            adjList[i] = new List<int>();
        }
    }
    public static void AddEdge(int a, int b)
    {
        adjList[a].Add(b);
        adjList[b].Add(a);
    }

    public static void Print()
    {
        for (int i = 0; i < adjList.Length; i++)
        {
            Console.Write($"{i}: ");
            foreach (int v in adjList[i])
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }
    }
}

static class matching
{
    static public void matching_()
    {
        ADJ_Graph.AddEdge(0, 1);

        ADJ_Graph.AddEdge(1, 4);
        ADJ_Graph.AddEdge(1, 5);
        ADJ_Graph.AddEdge(1, 6);
        ADJ_Graph.AddEdge(1, 7);

        ADJ_Graph.AddEdge(2, 3);
        ADJ_Graph.AddEdge(2, 4);

        ADJ_Graph.AddEdge(3, 5);

        ADJ_Graph.AddEdge(4, 6);

        ADJ_Graph.AddEdge(5, 6);
        ADJ_Graph.AddEdge(5, 7);

        ADJ_Graph.AddEdge(6, 7);
        ADJ_Graph.AddEdge(6, 8);
        ADJ_Graph.AddEdge(6, 9);

        ADJ_Graph.AddEdge(7, 9);
    }
}

