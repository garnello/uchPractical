
// Task 1

internal class Program
{
    public static void Main(string[] args)
    {

        int[] array = { 1, 3, 6, 2, 3, 1, 14, 11 };
        bool k = false;
        Array.Sort(array);

        foreach (int i in array)
        {
            if (array[i - 1] == array[i])
            {
                k = true;
                Console.Write($"Числа повторяются, к = {k}");
                Console.ReadKey();  
                break;
            }
            else
            {
                k = false;
                Console.Write($"Числа не повторяются, к = {k}");
                Console.ReadKey();
                break;
            }
        }
    }
}

/*Console.Write("Введите значение в строку S:");
String s = Console.ReadLine();

Console.Write("Введите значение в строку J:");
String j = Console.ReadLine();

int result = 0;

for (int i = 0; i < s.Length; i++)
{
    for (int h = 0; h < j.Length; h++)
    {
        if (s[i] == j[h])
        {
            result++;
        }
    }
}
Console.WriteLine(result);*/

// Task 2

/*class UP
{
    static void uniqueCombination(int l, int sum, int target, List<int> allCandidates, List<int> newCandidates)
    {
        if (sum == target)
        {
            Console.Write("{");
            for (int i = 0; i < allCandidates.Count; i++)
            {
                if (i != 0)
                {
                    Console.Write(" ");
                }

                Console.Write(allCandidates[i]);

                if (i != allCandidates.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
            return;
        }

        for (int i = l; i < newCandidates.Count; i++)
        {
            if (sum + newCandidates[i] > target)
            {
                continue;
            }

            if (i > l && newCandidates[i] == newCandidates[i - 1])
            {
                continue;
            }

            allCandidates.Add(newCandidates[i]);
            uniqueCombination(i + 1, sum + newCandidates[i], target, allCandidates, newCandidates);
            allCandidates.RemoveAt(allCandidates.Count - 1);
        }
    }


    static void Combination(List<int> newCandidates, int target)
    {
        newCandidates.Sort();

        List<int> allCandidates = new List<int>();

        uniqueCombination(0, 0, target, allCandidates, newCandidates);
    }


    public static void Main()
    {
        int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
        List<int> newCandidates = new List<int>(candidates);

        int target = 8;

        Combination(newCandidates, target);
    }
}*/
