

public class firsttry
{
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[N];

        string[] stringarr = Console.ReadLine().Split(' ');
        for(int i = 0; i < N; i++)
        {
            arr[i] = Convert.ToInt32(stringarr[i]);
        }
        int[] ans = bubbleSort(arr);
        for(int i = 0; i < N; i++)
        {
            Console.Write(ans[i] + " ");
        }

    }

    static int[] bubbleSort(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }
        return arr;
    }
    // List<int> list = listdemo();
    //Console.WriteLine(list.Count);
    static double factorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        else
        {
            return num * factorial(num - 1);
        }
    }
    static List<int> listdemo()
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        return list;
    }
}
