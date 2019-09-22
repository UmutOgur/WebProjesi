using CoreSeminerWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreSeminerWeb.Providers
{
    public class ApiProvider
    {
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:50773")
            };
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public List<ProductModel> GetService()
        {
            HttpClient client = GetClient();
            HttpResponseMessage response = client.GetAsync("north/product").Result;
            List<ProductModel> returnList = new List<ProductModel>();
            if (response.IsSuccessStatusCode)
            {
                string jsondata = response.Content.ReadAsStringAsync().Result;
                returnList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductModel>>(jsondata);
            }
            return returnList;
        }

        public ProductModel GetService(int id)
        {
            HttpClient client = GetClient();
            HttpResponseMessage response = client.GetAsync($"north/product/{id}").Result;
            ProductModel returnList = new ProductModel();
            if (response.IsSuccessStatusCode)
            {
                string jsondata = response.Content.ReadAsStringAsync().Result;
                returnList = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductModel>(jsondata);
            }
            return returnList;
        }

        public PagingModel GetService(int page, int size)
        {
            HttpClient client = GetClient();
            HttpResponseMessage response = client.GetAsync($"north/product/{page}/{size}").Result;
            PagingModel returnList = new PagingModel();
            if (response.IsSuccessStatusCode)
            {
                string jsondata = response.Content.ReadAsStringAsync().Result;
                returnList = Newtonsoft.Json.JsonConvert.DeserializeObject<PagingModel>(jsondata);
            }
            return returnList;
        }
    }
}
