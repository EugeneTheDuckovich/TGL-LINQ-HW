namespace source
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input N:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine($"factorial of N: {Factorial(n)}");
                Console.WriteLine($"N-th fibbonacci number: {Fibbonacci(n)}");
            }
        }

        static int Factorial(int N)
        {
            if (N <= 0) return 0;
            int[] natural = new int[N];
            for(int i = 1; i <= N; i++) natural[i - 1] = i;
            return natural.Aggregate((x, y) => x * y);
        }

        static int Fibbonacci(int N)
        {
            if(N <= 0) return 0;
            if(N == 1) return 1;
            int[] fib_arr = new int[] { 0, 1 };

            for (int i = 1; i < N; i++)
            {
                fib_arr = new int[] { fib_arr[1], fib_arr.Aggregate((x, y) => x + y)};
            }

            return fib_arr.Aggregate((x, y) => x + y);
        }
    }
}