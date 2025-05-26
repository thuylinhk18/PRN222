using System.Collections.Concurrent;
using System.Diagnostics;

namespace PLINQ_Demonstration_02
{
     class Program
    {
        private static bool isPrime(int number)
        {
            bool result = true;
            if (number < 2)
            {
                return false;
            }
            for (var divisor = 2; divisor <= Math.Sqrt(number) && result == true; divisor++) {
                if (number % divisor == 0)
                {
                    result = false;
                }
            }
            return result;
        }
        private static IList<int> getPrimeList(IList<int> numbers) 
            => numbers.Where(isPrime).ToList(); 
        private static IList<int> getPrimeIsListWithParallel(IList<int> numbers)
        {
            var primeNumbers = new ConcurrentBag<int>();
            Parallel.ForEach(numbers, number =>
            {
                if (isPrime(number))
                {
                    primeNumbers.Add(number);
                }
            });
            return primeNumbers.ToList();
        }
        static void Main()
        {
            var limit = 2_000_000;
            var numbers = Enumerable.Range(0, limit).ToList();
            var watch = Stopwatch.StartNew();
            var primeNumbersFromForeach = getPrimeList(numbers);
            watch.Stop();

            var watchForParallel  = Stopwatch.StartNew();
            var primeNumbersFromParallelForeach = getPrimeIsListWithParallel(numbers);   
            watchForParallel.Stop();

            Console.WriteLine($"Classical foreach loop | Total prime numbers :" +
                $"{primeNumbersFromForeach.Count} | Time Taken : " +
                $"{watch.ElapsedMilliseconds} ms.");
            Console.WriteLine($"Parallel.Foreach loop | Total prime numbers :" +
               $"{primeNumbersFromParallelForeach.Count} | Time Taken : " +
               $"{watchForParallel.ElapsedMilliseconds} ms.");


        }
    }
}
