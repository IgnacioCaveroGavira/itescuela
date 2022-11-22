public class DatetimeFormat{

    public static void Start(){

        var date = new DateTime(2022,9,1);
        Console.WriteLine(date.ToString("yyyyMMddTHHmmssZ"));


        string dateString = "2022-09-30T23:05:00";
        DateTime date2 = DateTime.Parse(dateString);
        Console.WriteLine(date2.ToString());


        Console.WriteLine("ConvertToUnixTime: 2022,9,1");
         var unixTimeFrom = ConvertToUnixTime(date);
            Console.WriteLine(unixTimeFrom);


    }


     private static int ConvertToUnixTime(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1);
            return (Int32)(date.Subtract(epoch)).TotalSeconds;
        }
}