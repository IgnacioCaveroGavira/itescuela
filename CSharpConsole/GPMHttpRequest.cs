using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;


public class GPMHttpRequest
{

    public static void Start()
    {


        string _aPIUrl = "https://webapipushenergy.horizon.greenpowermonitor.com/api/";
        string _tokenURI = "Account/Token";
        string _username = "webapi_quintas1";
        string _password = "4PjhsgfWDp5D";


        string requestAuthenticate = "{\"username\" : \"" + _username + "\", \"password\" : \"" + _password + "\" }";

        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        var httpClient = new HttpClient(clientHandler);
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        httpClient.BaseAddress = new Uri(_aPIUrl);


        HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _tokenURI);
        httpRequestMessage.Content = new StringContent(requestAuthenticate, Encoding.UTF8, "application/json");

        var aux = httpClient.Send(httpRequestMessage);
        if (aux.IsSuccessStatusCode)
        {
                    Console.WriteLine("Bingo!");
        }

          Console.WriteLine("FIN!");


          
    }
}