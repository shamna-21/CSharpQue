namespace LogicalQue1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            var a=Console.ReadLine();
            if (int.TryParse(a, out var b)) {
                EvenOrOdd(b);
            }
            else
            {
               
                Console.WriteLine("enter a valid number");
            }
           
        }
        static void EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
