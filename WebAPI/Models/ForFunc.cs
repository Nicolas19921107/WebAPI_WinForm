using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            var URLEncodedData = new FormUrlEncodedContent(formDataDic);
            return await PosttoBack(URLEncodedData, BaseURL);
        }

        public async Task<string> SendinJSON(Human data,Uri BaseURL)
        {
            HttpContent PostJSON = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            return await PosttoBack(PostJSON, BaseURL);
        }

        public async Task<string> SendinJSON(List<string>test, Uri BaseURL)
        {
            HttpContent PostJSON = new StringContent(JsonConvert.SerializeObject(test), Encoding.UTF8, "application/json");
            return await PosttoBack(PostJSON, BaseURL);
        }


        public async Task<string> SendinJSON(List<Human>DataList, Uri BaseURL)
        {
            HttpContent PostJSON = new StringContent(JsonConvert.SerializeObject(DataList), Encoding.UTF8, "application/json");
            return await PosttoBack(PostJSON, BaseURL);
        }
        public async Task<string> SendinJSON(Person DataList, Uri BaseURL)
        {
            HttpContent PostJSON = new StringContent(JsonConvert.SerializeObject(DataList), Encoding.UTF8, "application/json");
            return await PosttoBack(PostJSON, BaseURL);
        }
        public async Task<string> SendinJSON(List<Person> DataList, Uri BaseURL)
        {
            HttpContent PostJSON = new StringContent(JsonConvert.SerializeObject(DataList), Encoding.UTF8, "application/json");
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


        public async Task<string> PosttoBack(FormUrlEncodedContent URLEncodedData, Uri BaseURL)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                HttpResponseMessage response = await client.PostAsync(BaseURL, URLEncodedData);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        public string QueryString(List<string> Age)
        {
          NameValueCollection QS=HttpUtility.ParseQueryString(string.Empty);
            foreach (var item in Age)
            {
                QS.Add("Age", item);
            }
            return QS.ToString();
        }

        public string QueryString(List<Human>DataList)
        {
            NameValueCollection QS = HttpUtility.ParseQueryString(string.Empty);
            for (int i = 0; i < DataList.Count; i++)
            {
                QS.Add($"DataList[{i}][Name]", DataList[i].Name);
                QS.Add($"DataList[{i}][Age]",DataList[i].Age.ToString());
            }
            return QS.ToString();
        }


        public Dictionary<string, string> CreateNewDic(List<string> Name, List<string> Age,int Judge)
        {
            Dictionary<string, string> formDataDic = new Dictionary<string, string>();
            switch(Judge)
            {
                case 1:
                    formDataDic.Add("Name", Name[0]);
                    formDataDic.Add("Age", Age[0]);
                    break;
                case 2:
                    string NameArr = "";
                    foreach (var item in Name)
                    {
                      NameArr += item + ",";
                    };
                    formDataDic.Add("", NameArr.TrimEnd(','));
                    break;
            }
            return formDataDic;
        }
    }

  
}