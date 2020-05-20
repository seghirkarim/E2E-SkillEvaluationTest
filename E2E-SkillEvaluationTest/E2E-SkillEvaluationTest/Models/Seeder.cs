using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace E2E_SkillEvaluationTest.Models
{
    public class Seeder
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Todo>> GetSeedDataAsync()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Todo>>(responseBody);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
