using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productsConsume
{
    internal class ordersDetails
    {
        public int oId { get; set; }
        public int cId { get; set; }
        public int pId { get; set; }

        public string oStatus { get; set; }

        public List<ordersDetails> ConsumeOrdersInProgress()
        {
            string url = "https://localhost:7244/api/Orders/3.AllOrdersInProgress";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var call = client.GetAsync(url);
            var response = call.Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var data = response.Content;

                List<ordersDetails> ordersdata = data.ReadAsAsync<List<ordersDetails>>().Result;

                call.Wait();
                return ordersdata;


            }
            else
            {
                throw new Exception("Comments cannot be fetched");
            }
        }
        public List<ordersDetails> ConsumeOrdersCid(int cId)
        {
            string url = "https://localhost:7244/api/Orders/4.GetOrderByCID/" + cId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var call = client.GetAsync(url);
            var response = call.Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var data = response.Content;

                List<ordersDetails> ordersdata = data.ReadAsAsync<List<ordersDetails>>().Result;

                call.Wait();
                return ordersdata;


            }
            else
            {
                throw new Exception("Comments cannot be fetched");
            }
        }


    }
}
