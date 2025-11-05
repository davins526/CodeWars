using System.Linq;
public static class Kata
{
    public static string Solution(string str)
    {
        var orggrev = new string(str.Reverse().ToArray());
        return orggrev;
    }
}