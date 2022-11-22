public class FormateoConComillas{

    public static void Start(){

       string usuario = "Roberto";
       string password = "1234ACB";

        string res = "{\"username\" : \"" + usuario + "\", \"password\" : \"" +password +"\" }";
        string _aPIUrl = "https://webapipushenergy.horizon.greenpowermonitor.com/api/Account/Token";

        Console.WriteLine(res);
        Console.WriteLine(_aPIUrl);

    }
}