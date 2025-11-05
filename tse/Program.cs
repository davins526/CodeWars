namespace CodeWars;

public static class Task
{
    public static string RepeatStr(int n, string s)
    {
        string R = string.Empty;

        for (int i = 0; i <= n; i++)
        {
            R += s;
        }
        return R;
    } 
}