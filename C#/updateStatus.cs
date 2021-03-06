using System;
using System.Net.Http;

// Request an update to the status of a previously submitted order.

// more details at https://b2b.cofacecentraleurope.com/web/online/api-docs/bi/doc//operation/updateStatus


namespace ConsoleProgram
{
    public class Class1
    {
        static void Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "https://test.cofacecentraleurope.com/api/bi/v1/order/603f5ea2-b869-46c3-a85e-ed2677c1e4ed/status";
                string payload = "{\"action\": \"cancel\",\"cancel_reason\": \"order placed by mistake\"}";
                HttpContent content = new StringContent(payload, System.Text.Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Add("api_key", "8842ace2-e377-48d9-b129-f952950ea535");
                var response = httpClient.PutAsync(new Uri(url), content).Result;
                Console.WriteLine(response.ToString());
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
