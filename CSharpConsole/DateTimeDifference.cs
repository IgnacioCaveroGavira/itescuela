public class DateTimeDifference
{

    public static void Start()
    {
        var timestampUTC = DateTime.UtcNow;
        var timestampLocal = DateTime.Now;

        var datetimeUTC = new DateTime(timestampUTC.Year, timestampUTC.Month, timestampUTC.Day, timestampUTC.Hour, 0, 0);
        var datetimeLocal = new DateTime(timestampLocal.Year, timestampLocal.Month, timestampLocal.Day, timestampLocal.Hour, 0, 0);

        var hourDifference = (datetimeUTC - datetimeLocal).TotalHours;


        Console.WriteLine(timestampUTC);
        Console.WriteLine(timestampLocal);

        Console.WriteLine(datetimeUTC);
        Console.WriteLine(datetimeLocal);
        Console.WriteLine(hourDifference);

        Console.WriteLine(datetimeLocal.AddHours(hourDifference));
    }

}