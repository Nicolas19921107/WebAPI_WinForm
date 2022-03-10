using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WebAPI.Models
{
    public class ForFunc
    {
        public async Task<string> SendinUrlEncoded(Dictionary<string, string> formDataDic,Uri BaseURL)
        {
            using(HttpClient client=new HttpClient() )
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                var formData = new FormUrlEncodedContent(formDataDic);
                HttpResponseMessage responseSimpleModelBinding = await client.PostAsync(BaseURL, formData);
                responseSimpleModelBinding.EnsureSuccessStatusCode();
                string ResponseBodySimpleModelBinding = await responseSimpleModelBinding.Content.ReadAsStringAsync();
                return ResponseBodySimpleModelBinding;
            }

        }

        public async Task<string> SendinJSON(Human data,Uri BaseURL)
        {

                string JSON = JsonConvert.SerializeObject(data);
                HttpContent PostJSON = new StringContent(JSON, Encoding.UTF8, "application/json");
            //HttpResponseMessage responseModelBindObj = await client.PostAsync(BaseURL, PostContentModelBindObj);
            //responseModelBindObj.EnsureSuccessStatusCode();
            //string ResponseBodyModelBindObj = await responseModelBindObj.Content.ReadAsStringAsync();

            return await PosttoBack(PostJSON, BaseURL);
            
        }

        private async Task<string> PosttoBack(HttpContent JSONData, Uri BaseURL)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(BaseURL, JSONData);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}