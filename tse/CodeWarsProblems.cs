class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        double sum = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;
        }
        return sum / count;

    }
}