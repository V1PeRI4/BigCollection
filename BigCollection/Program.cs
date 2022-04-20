namespace BigCollection;

internal class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        FillList(list, 8);
        PrintList(list);
        LocalMina(list);

    }

    static void FillList(List<int> list, int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            list.Add(random.Next(1,10));
        }
    }

    static void PrintList(List<int> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void LocalMina(List<int> list)
    {
        int count = 0;
        for (int i = 1; i < list.Count; i++)
        {
            if (i + 1 < list.Count )
            {
                if (list[i] < list[i - 1] && list[i] < list[i + 1])
                    count++;
            }
        }
        Console.WriteLine($"Количество локальных минимумов - {count}");
    }
}
