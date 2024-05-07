using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPsClientCalls
{
    internal class PostDataAPI
    {
        public int userId { get; set; }
        public int id { get; set; }

        public string title { get; set; }
        public string body { get; set; }


        public List<PostDataAPI> ConsumePostData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var call = client.GetAsync(url);

            var response = call.Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = response.Content;

                List<PostDataAPI> postdata = data.ReadAsAsync<List<PostDataAPI>>().Result;

                call.Wait();
                return postdata;
            }

            else
            {
                throw new Exception("Could not get the data,please contact admin");
            }


        }


        public PostDataAPI GetPostById(int id)
        {

            string url = "https://jsonplaceholder.typicode.com/posts/" + id;

            HttpClient client = new HttpClient(); client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            

            var call = client.GetAsync(url);

            var response = call.Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var data= response.Content;

                PostDataAPI result= data.ReadAsAsync<PostDataAPI> ().Result; call.Wait();

                return result;
            }

            else if (response.StatusCode==System.Net.HttpStatusCode.NotFound);

            throw new Exception("PLease contact Admin");
        }



    }
}
