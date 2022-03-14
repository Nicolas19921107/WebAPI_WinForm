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


    public class WebClientHandle
    {
        public string QueryString(string Name,string Age)
        {
            NameValueCollection QS = HttpUtility.ParseQueryString(string.Empty);
            QS.Add("Name", Name);
            QS.Add("Age", Age);
            
            return QS.ToString();
        }
        public string QueryStringComplex(List<string> Name, List<string> Age,string RequestAction)
        {
            string QS = "";
            switch (RequestAction)
            {
                case "SimpleModelBindingArray":
                    
                    for (int i = 0; i < Name.Count; i++)
                    {
                        QS += $"Name[]={Name[i]}&Age[]={Age[i]}&";
                    }
                    return QS.Substring(0, QS.Length - 1);
                case "ModelBindingArray":
                    for (int i = 0; i < Name.Count; i++)
                    {
                        QS += $"[{i}][Name]={Name[i]}&[{i}][Age]={Age[i]}&";
                    }
                    return QS.Substring(0, QS.Length - 1);
                case "ModelBindingArrayJSON":
                    List<Human> DataList = new List<Human>();
                    for (int i = 0; i < Name.Count; i++)
                    {
                        Human Data = new Human();
                        Data.Name = Name[i];
                        Data.Age = Int32.Parse(Age[i]);
                        DataList.Add(Data);
                    };
                    return JsonConvert.SerializeObject(DataList);
                case "ModelBindingNestedObj":
                    QS += $"Name={Name[0]}&Age={Age[0]}&";
                    if (Name.Count < 1)
                    {
                        return QS.Substring(0, QS.Length - 1);
                    }
                    else
                    {
                        for (int i = 1; i < Name.Count; i++)
                        {
                            QS += $"Friends[{i-1}][Name]={Name[i]}&Friends[{i-1}][Age]={Age[i]}&";
                        }
                        return QS.Substring(0, QS.Length - 1);
                    }
                case "ModelBindingNestedObjJSON":
                    Person DataListPerson = new Person();
                    List<Person> Friends = new List<Person>();
                    DataListPerson.Name = Name[0];
                    DataListPerson.Age = Int32.Parse(Age[0]);
                    for (int i = 1; i < Name.Count; i++)
                    {
                        Person FriendAdd = new Person();
                        FriendAdd.Name = Name[i];
                        FriendAdd.Age = Int32.Parse(Age[i]);
                        Friends.Add(FriendAdd);
                        DataListPerson.Friends = Friends;
                    }
                    return JsonConvert.SerializeObject(DataListPerson);
                case "ModelBindingArrayNestedObj":
                    QS += $"[0][Name]={Name[0]}&[0][Age]={Age[0]}&";
                    if (Name.Count < 1)
                    {
                        return QS.Substring(0, QS.Length - 1);
                    }
                    else
                    {
                        for (int i = 1; i < Name.Count; i++)
                        {
                            QS += $"[1][Friends][{i - 1}][Name]={Name[i]}&[1][Friends][{i - 1}][Age]={Age[i]}&";
                        }
                        return QS.Substring(0, QS.Length - 1);
                    }
                case "ModelBindingArrayNestedObjJSON":
                    List<Person> DataListTop = new List<Person>();
                    List<Person> DataListSecond = new List<Person>();
                    Person DataOne = new Person();
                    DataOne.Name = Name[0];
                    DataOne.Age = Int32.Parse(Age[0]);
                    DataListTop.Add(DataOne);
                    for (int i = 1; i < Name.Count; i++)
                    {
                        Person DataFriends = new Person();
                        DataFriends.Name = Name[i];
                        DataFriends.Age = Int32.Parse(Age[i]);
                        DataListSecond.Add(DataFriends);
                    }
                    if (Name.Count > 1)
                    {
                        DataListTop.Add(DataOne = new Person());
                        DataListTop[1].Friends = DataListSecond;
                    }
                        return JsonConvert.SerializeObject(DataListTop);
                default:
                    return "";
            }
  
        }

    }

  
}