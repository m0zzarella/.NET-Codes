using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productsConsume
{
    internal class productDetails
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public double pPrice { get; set; }
        public int pAvailableQty { get; set; }
        public string pDescription { get; set; }
        public bool pIsInStock { get; set; }

        public List<productDetails> ConsumeProductsPriceRange(int range1, int range2)
        {
            string url = $"https://localhost:7244/api/Products/1.AllProductsPriceRange/{range1}/{range2}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var call = client.GetAsync(url);
            var response = call.Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var data = response.Content;

                List<productDetails> productsdata = data.ReadAsAsync<List<productDetails>>().Result;

                call.Wait();
                return productsdata;
            }
            else
            {
                throw new Exception("Comments cannot be fetched");
            }
        }

        public List<productDetails> ConsumeAllProducts()
        {
            string url = $"https://localhost:7244/api/Products/ViewAllProducts";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var call = client.GetAsync(url);
            var response = call.Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var data = response.Content;

                List<productDetails> productsdata = data.ReadAsAsync<List<productDetails>>().Result;

                call.Wait();
                return productsdata;


            }
            else
            {
                throw new Exception("Comments cannot be fetched");
            }
        }



    }
}
