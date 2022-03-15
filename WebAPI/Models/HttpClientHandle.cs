using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading;
using System.Net;

namespace WebAPI.Models
{
    public class HttpClientHandle
    {
        public string SendinJSON(string Name,string Age,Uri BaseURL)
        {
            Human data = new Human();
            data.Name = Name;
            data.Age =Int32.Parse(Age);
            HttpContent JSONData = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            return PostJSON(JSONData, BaseURL);
        }


        private string PostJSON(HttpContent JSONData, Uri BaseURL)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.PostAsync(BaseURL, JSONData).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result.ToString();
            }
        }

        public string PostURL(FormUrlEncodedContent URLData, Uri BaseURL)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                var response =client.PostAsync(BaseURL, URLData).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result.ToString();
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

        public string CreateNewDic(string Name, string Age,Uri BaseURL)
        {
            Dictionary<string, string> DicData = new Dictionary<string, string>();
            DicData.Add("Name", Name);
            DicData.Add("Age", Age);
            var URLData = new FormUrlEncodedContent(DicData);
            return PostURL(URLData, BaseURL);
        }
        public string CreateNewDic(List<string> Name, List<string> Age, Uri BaseURL, string ActionName)
        {
            Dictionary<string, string> DicData = new Dictionary<string, string>();
            switch (ActionName)
            {
                case "ModelBindingArray":
                    for (int i = 0; i < Name.Count; i++)
                    {
                        DicData.Add($"[{i}][Name]",$"{Name[i]}");
                        DicData.Add($"[{i}][Age]", $"{Age[i]}");   
                    }
                    break;
                case "ModelBindingArrayJSON":
                    List<Human> DataList = new List<Human>();
                    for (int i = 0; i < Name.Count; i++)
                    {
                        Human Data = new Human();
                        Data.Name = Name[i];
                        Data.Age = Int32.Parse(Age[i]);
                        DataList.Add(Data);
                    };
                    HttpContent JSONData = new StringContent(JsonConvert.SerializeObject(DataList), Encoding.UTF8, "application/json");
                    return PostJSON(JSONData, BaseURL);
                default:
                    break;
            }
            var URLData = new FormUrlEncodedContent(DicData);
            return PostURL(URLData, BaseURL);
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
        public string QueryStringComplex(List<string> Name, List<string> Age,string ActionName)
        {
            string QS = "";
            switch (ActionName)
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

        public string PostData(string Name,string Age,string ContentType,Uri BaseURL)
        {
            using(WebClient client=new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, ContentType);
                if (ContentType == "application/x-www-form-urlencoded")
                {
                    return client.UploadString(BaseURL, QueryString(Name, Age));
                }
                else
                {
                    Human PostDataJSON = new Human() { Name = Name, Age = Int32.Parse(Age) };
                    return client.UploadString(BaseURL,JsonConvert.SerializeObject(PostDataJSON));
                }
            }
        }
        public string PostData(List<string> Name, List<string> Age, Uri BaseURL, string ContentType ,string ActionName)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, ContentType);
                if (ContentType == "application/x-www-form-urlencoded")
                {
                    return client.UploadString(BaseURL, QueryStringComplex(Name, Age, ActionName));
                }
                else
                {
                    return client.UploadString(BaseURL, QueryStringComplex(Name, Age, ActionName));
                }
            }
        }

    }


    public class RestSharpClient
    {
        public string Send(RestRequest request, Uri BaseURL)
        {
            var client = new RestClient(BaseURL);
            request.Method = Method.Post;
            CancellationToken cancellation = default;
            return client.ExecutePostAsync(request, cancellation).GetAwaiter().GetResult().Content;
        }

        public string PostURL(string Name, string Age, Uri BaseURL)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Name", Name);
            request.AddParameter("Age", Age);
            return Send(request, BaseURL);
        }

        public string PostURL(List<string> Name, List<string> Age, Uri BaseURL, string ActionName)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            switch (ActionName)
            {
                case "SimpleModelBindingArray":
                   for (int i = 0; i < Name.Count; i++)
                    {
                        request.AddQueryParameter("Name[]", Name[i]);
                        request.AddQueryParameter("Age[]", Age[i]);
                    }
                    break;
                case "ModelBindingArray":
                    for (int i = 0; i < Name.Count; i++)
                    {
                        request.AddParameter($"[{i}][Name]", $"{Name[i]}");
                        request.AddParameter($"[{i}][Age]", $"{Age[i]}");
                    }
                    break;
                case "ModelBindingNestedObj":
                    request.AddParameter("Name", Name[0]);
                    request.AddParameter("Age", Age[0]);
                    if (Name.Count < 1)
                    {
                        break;
                    }
                    else
                    {
                        for (int i = 1; i < Name.Count; i++)
                        {
                            request.AddParameter($"Friends[{i - 1}][Name]", $"{Name[i]}");
                            request.AddParameter($"Friends[{i - 1}][Age]", $"{Age[i]}");
                        }
                        break;
                    }
                case "ModelBindingArrayNestedObj":
                    request.AddParameter("[0][Name]", Name[0]);
                    request.AddParameter("[0][Age]", Age[0]);
                    if (Name.Count < 1)
                    {
                        break;
                    }
                    else
                    {
                        for (int i = 1; i < Name.Count; i++)
                        {
                            request.AddParameter($"[1][Friends][{i - 1}][Name]", $"{Name[i]}");
                            request.AddParameter($"[1][Friends][{i - 1}][Age]", $"{Age[i]}");
                        }
                        break;
                    }
            }
            return Send(request, BaseURL);
        }

        public string PostJSON(string Name, string Age, Uri BaseURL)
        {
            var request = new RestRequest();
            Human PostDataJSON = new Human() { Name = Name, Age = Int32.Parse(Age) };
            request.AddJsonBody(PostDataJSON);
            return Send(request, BaseURL);
        }
        public string PostJSON(List<string> Name, List<string> Age, Uri BaseURL,string ActionName)
        {
            var request = new RestRequest();
            switch (ActionName)
            {
                case "ModelBindingArray":
                    List<Human> PostDataJSON = new List<Human>();
                    for (int i = 0; i < Name.Count; i++)
                    {
                        Human Data = new Human();
                        Data.Name = Name[i];
                        Data.Age = Int32.Parse(Age[i]);
                        PostDataJSON.Add(Data);
                    };
                    request.AddJsonBody(PostDataJSON);
                    break;
                case "ModelBindingNestedObj":
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
            return Send(request, BaseURL);

        }
    }


}