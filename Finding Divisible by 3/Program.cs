namespace Finding_Divisible_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 0; i < 21; i++)
            {
                if(i % 3 == 0)
                {
                    sum += i;
                } 
            }
            Console.WriteLine($"Sum of all integers divisible by 3 is {sum}");
            Console.ReadLine();
        }
    }
}