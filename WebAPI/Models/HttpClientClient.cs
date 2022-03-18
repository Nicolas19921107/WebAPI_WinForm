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
    /// <summary>
    /// RestSharp 套件
    /// </summary>
    public class RestSharpRequest
    {
        /// <summary>
        /// 組合 QueryString( RestSharp 套件 )
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Age">年齡</param>
        /// <param name="BaseURL">串接 APi 的 BaseURL</param>
        /// <param name="ActionName">Controller 的 Action</param>
        /// <param name="ContentType">Request 的發送格式</param>
        /// <returns>PostData 回傳的結果</returns>
        public string ComposeQueryString(List<string> Name, List<string> Age, string BaseURL, string ActionName, string ContentType)
        {
            var request = new RestRequest();
            ComplexType ForComplex = new ComplexType();
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
                        BaseURL = $"{BaseURL}?Age={PostDataJSON.Age}";
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
                        request.AddJsonBody(ForComplex.ForHuman(Name[0],Age[0]));
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
                        request.AddJsonBody(ForComplex.ForListHuman(Name,Age));
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
                        request.AddJsonBody(ForComplex.ForPerson(Name,Age));
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
                       request.AddJsonBody(ForComplex.ForListPerson(Name,Age));
                    }
                    break;
            }
            return PostData(request, BaseURL);
        }
        /// <summary>
        /// 向 Controller 發送資料
        /// </summary>
        /// <param name="request">RestSharp 呼叫</param>
        /// <param name="BaseURL">串接 APi 的 BaseURL</param>
        /// <returns>後端回傳的內容</returns>
        public string PostData(RestRequest request, string BaseURL)
        {
            var client = new RestClient(new Uri(BaseURL));
            request.Method = Method.POST;
            CancellationToken cancellation = default;
            return client.ExecutePostAsync(request, cancellation).GetAwaiter().GetResult().Content;
        }
    }

    /// <summary>
    /// 其他連線套件( HttpClient 與 WebClient )
    /// </summary>
    public class OtherHttpRequest
    {
        /// <summary>
        /// 組合 QueryString( HttpClient 與 WebClient 套件 )
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Age">年齡</param>
        /// <param name="BaseURL">串接 APi 的 BaseURL</param>
        /// <param name="ActionName">Controller 的 Action</param>
        /// <param name="ContentType">Request 的發送格式</param>
        /// <param name="RequestHTTP">指定使用的連線套件( HttpClient 或 WebClient )</param>
        /// <returns>PostData 回傳的結果</returns>
        public string ComposeQueryString(List<string> Name, List<string> Age, string BaseURL, string ActionName, string ContentType, string RequestHTTP)
        {
            NameValueCollection QS = HttpUtility.ParseQueryString(string.Empty);
            ComplexType ForComplex = new ComplexType();
            switch (ActionName)
            {
                case "SimpleBinding":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("", Name[0]);
                        return PostData(QS.ToString(), $"{BaseURL}?Age={Age[0]}", ContentType, RequestHTTP);
                    }
                    else
                    {
                        var data = new { Name = Name[0], Age = Age[0] };
                        return PostData(JsonConvert.SerializeObject(data.Name), BaseURL + $"?Age={data.Age}", ContentType, RequestHTTP);
                    }
                case "ModelBindObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("Name", Name[0]);
                        QS.Add("Age", Age[0]);
                        return PostData(QS.ToString(), BaseURL, ContentType, RequestHTTP);
                    }
                    else
                    {
                        return PostData(JsonConvert.SerializeObject(ForComplex.ForHuman(Name[0],Age[0])), BaseURL, ContentType, RequestHTTP);
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
                        return PostData(QS.ToString(), $"{BaseURL}?{AgeArr.Substring(0, AgeArr.Length - 1)}", ContentType, RequestHTTP);
                    }
                    else
                    {
                        for (int i = 0; i < Age.Count; i++)
                        {
                            AgeArr += $"Age={Age[i]}&";
                        }
                        return PostData(JsonConvert.SerializeObject(Name), $"{BaseURL}?{AgeArr.Substring(0, AgeArr.Length - 1)}", ContentType, RequestHTTP);
                    }
                case "ModelBindingArray":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        for (int i = 0; i < Name.Count; i++)
                        {
                            QS.Add($"[{i}][Name]", $"{Name[i]}");
                            QS.Add($"[{i}][Age]", $"{Age[i]}");
                        }
                        return PostData(QS.ToString(), BaseURL, ContentType, RequestHTTP);
                    }
                    else
                    {
                        return PostData(JsonConvert.SerializeObject(ForComplex.ForListHuman(Name,Age)), BaseURL, ContentType, RequestHTTP);
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
                        return PostData(QS.ToString(), BaseURL, ContentType, RequestHTTP);
                    }
                    else
                    {
                        return PostData(JsonConvert.SerializeObject(ForComplex.ForPerson(Name,Age)), BaseURL, ContentType, RequestHTTP);
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
                        return PostData(QS.ToString(), BaseURL, ContentType, RequestHTTP);
                    }
                    else
                    {
                        return PostData(JsonConvert.SerializeObject(ForComplex.ForListPerson(Name,Age)), BaseURL, ContentType, RequestHTTP);
                    }
                default:
                    return "Error";
            }
        }

        /// <summary>
        /// 向後端發送資料
        /// </summary>
        /// <param name="QueryString">要送給後端的查詢參數</param>
        /// <param name="URL">串接 APi 的 BaseURL</param>
        /// <param name="ContentType">Request 的發送格式</param>
        /// <param name="RequestHTTP">指定使用的連線套件( HttpClient 或 WebClient )</param>
        /// <returns>後端回傳的內容</returns>
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

    /// <summary>
    /// 要處理的複雜型別資料
    /// </summary>
    public class ComplexType
    {
        /// <summary>
        /// Human 類別
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Age">年齡</param>
        /// <returns></returns>
        public Human ForHuman(string Name,string Age)
        {
            Human Data = new Human();
            Data.Name = Name;
            Data.Age = Int32.Parse(Age);
            return Data;
        }

        /// <summary>
        /// Human List
        /// </summary>
        /// <param name="Name">姓名的 List</param>
        /// <param name="Age">年齡的 List</param>
        /// <returns></returns>
        public List<Human> ForListHuman(List<string>Name,List<string>Age)
        {
            List<Human> DataList = new List<Human>();
            for (int i = 0; i < Name.Count; i++)
            {
                Human Data = new Human();
                Data.Name = Name[i];
                Data.Age = Int32.Parse(Age[i]);
                DataList.Add(Data);
            };
            return DataList;
        }

        /// <summary>
        /// Person 類別
        /// </summary>
        /// <param name="Name">姓名的 List </param>
        /// <param name="Age">年齡的 List </param>
        /// <returns></returns>
        public Person ForPerson(List<string> Name, List<string> Age)
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
            return DataListPerson;
        }

        /// <summary>
        /// Person List
        /// </summary>
        /// <param name="Name">姓名的 List</param>
        /// <param name="Age">年齡的 List</param>
        /// <returns></returns>
        public List<Person> ForListPerson(List<string> Name, List<string> Age)
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
            return DataListTop;
        }
    }

}
