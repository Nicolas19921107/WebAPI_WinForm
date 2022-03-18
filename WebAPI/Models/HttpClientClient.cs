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
using WebAPI.Models;

namespace WebAPI.Models
{

    public class RestSharpRequest
    {
        public string ComposeQueryString(List<string> Name, List<string> Age, Uri BaseURL, string ActionName, string ContentType)
        {
            var request = new RestRequest();
            switch (ActionName)
            {
                case "SimpleBinding":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        request.AddHeader("Content-Type", ContentType);
                        request.AddQueryParameter("Age", Age[0]);
                        request.AddParameter(new Parameter("", $"={Name[0]}", ContentType, ParameterType.RequestBody));
                    }
                    else
                    {
                        var PostDataJSON = new { Name = Name[0], Age = Int32.Parse(Age[0]) };
                        request.AddJsonBody(PostDataJSON.Name);
                        BaseURL = new Uri(BaseURL.AbsoluteUri + $"?Age={PostDataJSON.Age}");
                    }
                    return PostData(request, BaseURL);
                case "ModelBindObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        request.AddHeader("Content-Type", ContentType);
                        request.AddParameter("Name", Name[0]);
                        request.AddParameter("Age", Age[0]);
                    }
                    else
                    {
                        Human DataObj = new Human();
                        DataObj.Name = Name[0];
                        DataObj.Age = Int32.Parse(Age[0]);
                        request.AddJsonBody(DataObj);
                    }
                    return PostData(request, BaseURL);
                case "SimpleModelBindingArray":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        string NameArr = "";
                        for (int i = 0; i < Age.Count; i++)
                        {
                            request.AddQueryParameter("Age", Age[i]);
                            NameArr += $"={Name[i]}&";
                        }
                        request.AddParameter(new Parameter("", NameArr.Substring(0, NameArr.Length - 1), ContentType, ParameterType.RequestBody));
                    }
                    else
                    {
                        for (int i = 0; i < Age.Count; i++)
                        {
                            request.AddQueryParameter("Age", Age[i]);
                        }
                        request.AddJsonBody(Name);
                    }
                    break;
                case "ModelBindingArray":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        request.AddHeader("Content-Type", ContentType);
                        for (int i = 0; i < Name.Count; i++)
                        {
                            request.AddParameter($"[{i}][Name]", $"{Name[i]}");
                            request.AddParameter($"[{i}][Age]", $"{Age[i]}");
                        }
                    }
                    else
                    {
                        List<Human> PostDataJSON = new List<Human>();
                        for (int i = 0; i < Name.Count; i++)
                        {
                            Human Data = new Human();
                            Data.Name = Name[i];
                            Data.Age = Int32.Parse(Age[i]);
                            PostDataJSON.Add(Data);
                        };
                        request.AddJsonBody(PostDataJSON);
                    }
                    break;
                case "ModelBindingNestedObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        request.AddHeader("Content-Type", ContentType);
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
                        }
                    }
                    else
                    {
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
                        request.AddJsonBody(DataListPerson);
                    }
                    break;
                case "ModelBindingArrayNestedObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        request.AddHeader("Content-Type", ContentType);
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
                        }
                    }
                    else
                    {
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
                        request.AddJsonBody(DataListTop);
                    }
                    break;
            }
            return PostData(request, BaseURL);
        }
        public string PostData(RestRequest request, Uri BaseURL)
        {
            var client = new RestClient(BaseURL);
            request.Method = Method.POST;
            CancellationToken cancellation = default;
            return client.ExecutePostAsync(request, cancellation).GetAwaiter().GetResult().Content;
        }
    }

    public class OtherHttpRequest
    {
        public string ComposeQueryString(List<string> Name, List<string> Age, Uri BaseURL, string ActionName, string ContentType, string RequestHTTP)
        {
            NameValueCollection QS = HttpUtility.ParseQueryString(string.Empty);
            switch (ActionName)
            {
                case "SimpleBinding":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("", Name[0]);
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri + $"?Age={Age[0]}", ContentType, RequestHTTP);
                    }
                    else
                    {
                        var data = new { Name = Name[0], Age = Age[0] };
                        return PostData(JsonConvert.SerializeObject(data.Name), BaseURL.AbsoluteUri + $"?Age={data.Age}", ContentType, RequestHTTP);
                    }
                case "ModelBindObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("Name", Name[0]);
                        QS.Add("Age", Age[0]);
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri, ContentType, RequestHTTP);
                    }
                    else
                    {
                        Human DataObj = new Human();
                        DataObj.Name = Name[0];
                        DataObj.Age = Int32.Parse(Age[0]);
                        return PostData(JsonConvert.SerializeObject(DataObj), BaseURL.AbsoluteUri, ContentType, RequestHTTP);
                    }
                case "SimpleModelBindingArray":
                    string AgeArr = "";
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        for (int i = 0; i < Name.Count; i++)
                        {
                            QS.Add("", $"{Name[i]}");
                            AgeArr += $"Age={Age[i]}&";
                        }
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri + "?" + AgeArr.Substring(0, AgeArr.Length - 1), ContentType, RequestHTTP);
                    }
                    else
                    {
                        for (int i = 0; i < Age.Count; i++)
                        {
                            AgeArr += $"Age={Age[i]}&";
                        }
                        return PostData(JsonConvert.SerializeObject(Name), BaseURL.AbsoluteUri + "?" + AgeArr.Substring(0, AgeArr.Length - 1), ContentType, RequestHTTP);
                    }
                case "ModelBindingArray":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        for (int i = 0; i < Name.Count; i++)
                        {
                            QS.Add($"[{i}][Name]", $"{Name[i]}");
                            QS.Add($"[{i}][Age]", $"{Age[i]}");
                        }
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri, ContentType, RequestHTTP);
                    }
                    else
                    {
                        List<Human> DataList = new List<Human>();
                        for (int i = 0; i < Name.Count; i++)
                        {
                            Human Data = new Human();
                            Data.Name = Name[i];
                            Data.Age = Int32.Parse(Age[i]);
                            DataList.Add(Data);
                        };
                        return PostData(JsonConvert.SerializeObject(DataList), BaseURL.AbsoluteUri, ContentType, RequestHTTP);
                    }
                case "ModelBindingNestedObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("Name", Name[0]);
                        QS.Add("Age", Age[0]);
                        if (Name.Count > 1)
                        {
                            for (int i = 1; i < Name.Count; i++)
                            {
                                QS.Add($"Friends[{i - 1}][Name]", $"{Name[i]}");
                                QS.Add($"Friends[{i - 1}][Age]", $"{Age[i]}");
                            }
                        }
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri, ContentType, RequestHTTP);
                    }
                    else
                    {
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
                        return PostData(JsonConvert.SerializeObject(DataListPerson), BaseURL.AbsoluteUri, ContentType, RequestHTTP);
                    }
                case "ModelBindingArrayNestedObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("[0][Name]", Name[0]);
                        QS.Add("[0][Age]", Age[0]);
                        if (Name.Count > 1)
                        {
                            for (int i = 1; i < Name.Count; i++)
                            {
                                QS.Add($"[1][Friends][{i - 1}][Name]", Name[i]);
                                QS.Add($"[1][Friends][{i - 1}][Age]", Age[i]);
                            }
                        }
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri, ContentType, RequestHTTP);
                    }
                    else
                    {
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
                        return PostData(JsonConvert.SerializeObject(DataListTop), BaseURL.AbsoluteUri, ContentType, RequestHTTP);
                    }
                default:
                    return "Error";
            }
        }
        private string PostData(string QueryString, string URL, string ContentType, string RequestHTTP)
        {
            switch (RequestHTTP)
            {
                case "HttpClient":
                    using (HttpClient client = new HttpClient())
                    {
                        Uri BaseURL = new Uri(URL);
                        HttpContent Data = new StringContent(QueryString, Encoding.UTF8, ContentType);
                        var response = client.PostAsync(BaseURL, Data).GetAwaiter().GetResult();
                        response.EnsureSuccessStatusCode();
                        return response.Content.ReadAsStringAsync().Result.ToString();
                    }
                case "WebClient":
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add(HttpRequestHeader.ContentType, ContentType);
                        return client.UploadString(URL, QueryString);
                    }
                default:
                    return "Error";

            }

        }
    }
    public class WebApiConClient
    {
        public string QueryString(string Name, string Age, Uri BaseURL, string ContentType)
        {
            var request = new RestRequest();
            var client = new RestClient(BaseURL);
            request.Method = Method.POST;
            CancellationToken cancellation = default;
            request.AddHeader("Content-Type", ContentType);
            if (ContentType == "application/x-www-form-urlencoded")
            {
                request.AddParameter("Name", Name);
                request.AddParameter("Age", Age);
            }
            else
            {
                request.AddParameter("Name", Name);
                request.AddParameter("Age", Age);
            }
            return client.ExecutePostAsync(request, cancellation).GetAwaiter().GetResult().Content;
        }
    }

}
