using System.Text;

public static class Kata
{
    public static string CountSheep(int n)
    {
        if (n <= 0) return "";

        StringBuilder sb = new StringBuilder();

          for (System.Int32 i = 1; i <= n;  i++){
                sb.Append($"{i} sheep...");
            }
            return sb.ToString();
    }
}