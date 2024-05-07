using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPsClientCalls
{
    internal class fakeAPI
    {
        

            public int id { get; set; }

            public string title { get; set; }

            public double price { get; set; }

            public string description { get; set; }

            public List<fakeAPI> ConsumeFakeAPI()
            {
                string url = "https://fakestoreapi.com/products";
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var call = client.GetAsync(url);
                var response = call.Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    var data = response.Content;

                    List<fakeAPI> commentsdata = data.ReadAsAsync<List<fakeAPI>>().Result;

                    call.Wait();
                    return commentsdata;


                }
                else
                {
                    throw new Exception("Comments cannot be fetched");
                }
            }
        public fakeAPI GetFakeById(int id)
        {

            string url = "https://fakestoreapi.com/products/" + id;

            HttpClient client = new HttpClient(); client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            var call = client.GetAsync(url);

            var response = call.Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var data = response.Content;

                fakeAPI result = data.ReadAsAsync<fakeAPI>().Result; call.Wait();

                return result;
            }

            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound) ;

            throw new Exception("PLease contact Admin");
        }
    }
    }



