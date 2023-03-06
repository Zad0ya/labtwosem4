using System.Collections.Specialized;
namespace Lab2_3
{
    internal class stringlong
    {
        static void Main(string[] args)
        {
            Func<string, int> stringLengthDelegate = s => s.Length;
            List<string> strings = new List<string> { "успіх", "сила", "дихлордифенілтрихлорметилмета", "багатогранність" };
            foreach (string s in strings)
            {
                int length = stringLengthDelegate(s);
                Console.WriteLine("{0} - {1} символів", s, length);
            }
        }
    }
}