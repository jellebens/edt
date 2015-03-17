using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Out = System.Console;

namespace Sharpsolutions.Edt.Console.Simulator {
    class Program
    {
        private const string Token =
            "FkcduMOdgG6MQUigmTkRoapscbmYnVdhn1ih5kW5mnEd48MbQmlZqxJ0AD0rcwqJGCZiHmSjsD9NWD5e4GA28kwaTwb0A1OdVZI-hcujmuFPWGusOJ9HWiEwVH2t7VV6NczMUwY4dD9iSm3lvorsigNuSQaiDYXb4hGFKsf62g1KtOo607tmChyix_MQLUv8J_cC2L31yVUR1n_B-6dRMg";
        static void Main(string[] args)
        {
            Out.WriteLine("Press a key to start");
            Out.ReadKey();
            Out.WriteLine("Starting");

            for (int i = 0; i < 10000; i++)
            {
                RunAsync().Wait();
            }
            Out.WriteLine("Done");

            Out.ReadKey();
        }

        static async Task RunAsync()
        {
            var create = new
            {
                Name = Guid.NewGuid().ToString(),
                System = "TEST",
                Economy = "Extraction"
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44300/edt/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                Out.WriteLine("Posting...." + create.Name);
                var response = await client.PostAsJsonAsync("starport/create", create);

                if (response.IsSuccessStatusCode)
                {
                    Out.WriteLine("Done Posting....");
                }
                else
                {
                    Out.WriteLine("Error Posting...." + response.StatusCode);
                }

                
            }
        }
    }
}
