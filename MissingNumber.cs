internal class MissingNumber
{
    private static void Main(string[] args)
    {
        int [] arr ={1,2,3,5,6};
        int n = arr.Length;
       int total = (n + 1) * (n + 2) / 2;

        for (int i = 0; i < n; i++)
            total -= arr[i];
           System.Console.WriteLine(total);
        
    }
}