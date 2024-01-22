using System.Linq;
namespace SelectLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> Cube= Enumerable.Range(1, 10).Select(x => x*x*x);
            foreach (int numbers in Cube)
            {
                Console.WriteLine(numbers);
            }

            string[] fruits = { "apple", "mango", "orange", "grapes" };
            var query = fruits.Select((fruit, index) =>
                        new { index, fruit = fruit.Substring(1, index) });
            foreach( var x in query )
            {
                Console.WriteLine(x);
            }
        }
    }
}
