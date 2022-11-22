public class InaccessHttpRequest{

    public async static Task<int> Start(){

                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };                
                var httpClient = new HttpClient(clientHandler);
                httpClient.BaseAddress = new Uri("https://octopus.solarpark-online.com/ifms");
                httpClient.DefaultRequestHeaders.Add("apiKey", "c3c585d5-057d-412f-9231-8a1364c93969.01");
                var httpResponse = await httpClient.GetAsync("https://octopus.solarpark-online.com/ifms/sites/05ef4fca-4feb-11e6-a0c6-42010afa015a/segments?recursive=true");
                //var httpResponse = httpClient.GetAsync("https://exampldfgse.com");

                Console.WriteLine("Commmorr!!!");

                return 12;

    }
}