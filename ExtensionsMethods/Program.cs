
using ExtensionsMethods.Extensions;

class Program
{
    static void Main(string[] args)
    {
        int[] names = new[] {23,54,3,6,24,25,54,85,74};
        IEnumerable<int>? shuffledNames = names.Shuffle(2,4);

        foreach (var item in shuffledNames)
        {
            Console.Write(item+" ");
        }
    }

   
}