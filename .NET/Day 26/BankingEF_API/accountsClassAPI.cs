using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingEF_API
{
    internal class accountsClassAPI
    {
       


            public int accNo { get; set; }

        public string accName { get; set; }
        public string accType { get; set; }

            public double accBalance { get; set; }

            public bool accIsActive { get; set; }
        public int accBranch { get; set; }

        public List<accountsClassAPI> ConsumeAccountsAPI()
            {
                string url = "https://localhost:7013/api/AccountsInfoes/getAllProducts";
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var call = client.GetAsync(url);
                var response = call.Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    var data = response.Content;

                    List<accountsClassAPI> commentsdata = data.ReadAsAsync<List<accountsClassAPI>>().Result;

                    call.Wait();
                    return commentsdata;


                }
                else
                {
                    throw new Exception("Comments cannot be fetched");
                }
            }
            
        }
    }
