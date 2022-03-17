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
    public class HttpClientClient
    {
        public string QueryString(List<string> Name, List<string> Age, Uri BaseURL, string ActionName,string ContentType,HttpClient client)
        {
            NameValueCollection QS = HttpUtility.ParseQueryString(string.Empty);
            switch (ActionName)
            {  
                case "SimpleBinding":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("", Name[0]);
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri + $"?Age={Age[0]}",ContentType, client);
                    }
                    else
                    {
                        var data = new {Name = Name[0], Age = Age[0]};
                        return PostData(JsonConvert.SerializeObject(data.Name), BaseURL.AbsoluteUri + $"?Age={data.Age}", ContentType, client);
                    }
                case "ModelBindObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("Name", Name[0]);
                        QS.Add("Age", Age[0]);
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri,ContentType, client);
                    }
                    else
                    {
                        Human DataObj = new Human();
                        DataObj.Name = Name[0];
                        DataObj.Age = Int32.Parse(Age[0]);
                        return PostData(JsonConvert.SerializeObject(DataObj), BaseURL.AbsoluteUri, ContentType, client);
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
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri + "?" + AgeArr.Substring(0, AgeArr.Length - 1), ContentType, client);
                    }
                    else
                    {
                        for (int i = 0; i < Age.Count; i++)
                        {
                            AgeArr += $"Age={Age[i]}&";
                        }
                        return PostData(JsonConvert.SerializeObject(Name), BaseURL.AbsoluteUri + "?" + AgeArr.Substring(0, AgeArr.Length - 1), ContentType, client);
                    }
                case "ModelBindingArray":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        for (int i = 0; i < Name.Count; i++)
                        {
                            QS.Add($"[{i}][Name]", $"{Name[i]}");
                            QS.Add($"[{i}][Age]", $"{Age[i]}");
                        }
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri,ContentType, client);
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
                        return PostData(JsonConvert.SerializeObject(DataList), BaseURL.AbsoluteUri, ContentType, client);
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
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri, ContentType, client);
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
                        return PostData(JsonConvert.SerializeObject(DataListPerson), BaseURL.AbsoluteUri, ContentType, client);
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
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri, ContentType, client);
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
                        return PostData(JsonConvert.SerializeObject(DataListTop), BaseURL.AbsoluteUri, ContentType, client);
                    }
                default:
                    return "Error";
            }

        }

        private string PostData(string QueryString,string URL,string ContentType,HttpClient client)
        {
                Uri BaseURL = new Uri(URL);
                HttpContent Data = new StringContent(QueryString, Encoding.UTF8, ContentType);
                var response = client.PostAsync(BaseURL, Data).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result.ToString();
        }
    }

    public class WebClientClient
    {
        //public string QueryString(string Name,string Age)
        //{
        //    NameValueCollection QS = HttpUtility.ParseQueryString(string.Empty);
        //    QS.Add("Name", Name);
        //    QS.Add("Age", Age);
            
        //    return QS.ToString();
        //}
        public string QueryString(List<string> Name, List<string> Age,string ActionName,string ContentType, Uri BaseURL,WebClient client)
        {
            NameValueCollection QS = HttpUtility.ParseQueryString(string.Empty);
            //string QS = "";
            switch (ActionName)
            {
                case "SimpleBinding":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("", Name[0]);
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri + $"?Age={Age[0]}", ContentType,client);
                    }
                    else
                    {
                        var data = new { Name = Name[0], Age = Age[0] };
                        return PostData(JsonConvert.SerializeObject(data.Name), BaseURL.AbsoluteUri + $"?Age={data.Age}", ContentType,client);
                    }
                case "ModelBindObj":
                    if (ContentType == "application/x-www-form-urlencoded")
                    {
                        QS.Add("Name", Name[0]);
                        QS.Add("Age", Age[0]);
                        return PostData(QS.ToString(), BaseURL.AbsoluteUri, ContentType, client);
                    }
                    else
                    {
                        Human DataObj = new Human();
                        DataObj.Name = Name[0];
                        DataObj.Age = Int32.Parse(Age[0]);
                        return PostData(JsonConvert.SerializeObject(DataObj), BaseURL.AbsoluteUri, ContentType, client);
                    }
                //case "SimpleModelBindingArray":
                //    for (int i = 0; i < Name.Count; i++)
                //    {
                //        //QS += $"Age[]={Age[i]}&";
                //        QS += $"={Name[i]}&";
                //    }
                //    return QS.Substring(0, QS.Length - 1);
                //case "SimpleModelBindingArrayJSON":
                //    return JsonConvert.SerializeObject(Name);
                //case "ModelBindingArray":
                //    for (int i = 0; i < Name.Count; i++)
                //    {
                //        QS += $"[{i}][Name]={Name[i]}&[{i}][Age]={Age[i]}&";
                //    }
                //    return QS.Substring(0, QS.Length - 1);
                //case "ModelBindingArrayJSON":
                //    List<Human> DataList = new List<Human>();
                //    for (int i = 0; i < Name.Count; i++)
                //    {
                //        Human Data = new Human();
                //        Data.Name = Name[i];
                //        Data.Age = Int32.Parse(Age[i]);
                //        DataList.Add(Data);
                //    };
                //    return JsonConvert.SerializeObject(DataList);
                //case "ModelBindingNestedObj":
                //    QS += $"Name={Name[0]}&Age={Age[0]}&";
                //    if (Name.Count < 1)
                //    {
                //        return QS.Substring(0, QS.Length - 1);
                //    }
                //    else
                //    {
                //        for (int i = 1; i < Name.Count; i++)
                //        {
                //            QS += $"Friends[{i-1}][Name]={Name[i]}&Friends[{i-1}][Age]={Age[i]}&";
                //        }
                //        return QS.Substring(0, QS.Length - 1);
                //    }
                //case "ModelBindingNestedObjJSON":
                //    Person DataListPerson = new Person();
                //    List<Person> Friends = new List<Person>();
                //    DataListPerson.Name = Name[0];
                //    DataListPerson.Age = Int32.Parse(Age[0]);
                //    for (int i = 1; i < Name.Count; i++)
                //    {
                //        Person FriendAdd = new Person();
                //        FriendAdd.Name = Name[i];
                //        FriendAdd.Age = Int32.Parse(Age[i]);
                //        Friends.Add(FriendAdd);
                //        DataListPerson.Friends = Friends;
                //    }
                //    return JsonConvert.SerializeObject(DataListPerson);
                //case "ModelBindingArrayNestedObj":
                //    QS += $"[0][Name]={Name[0]}&[0][Age]={Age[0]}&";
                //    if (Name.Count < 1)
                //    {
                //        return QS.Substring(0, QS.Length - 1);
                //    }
                //    else
                //    {
                //        for (int i = 1; i < Name.Count; i++)
                //        {
                //            QS += $"[1][Friends][{i - 1}][Name]={Name[i]}&[1][Friends][{i - 1}][Age]={Age[i]}&";
                //        }
                //        return QS.Substring(0, QS.Length - 1);
                //    }
                //case "ModelBindingArrayNestedObjJSON":
                //    List<Person> DataListTop = new List<Person>();
                //    List<Person> DataListSecond = new List<Person>();
                //    Person DataOne = new Person();
                //    DataOne.Name = Name[0];
                //    DataOne.Age = Int32.Parse(Age[0]);
                //    DataListTop.Add(DataOne);
                //    for (int i = 1; i < Name.Count; i++)
                //    {
                //        Person DataFriends = new Person();
                //        DataFriends.Name = Name[i];
                //        DataFriends.Age = Int32.Parse(Age[i]);
                //        DataListSecond.Add(DataFriends);
                //    }
                //    if (Name.Count > 1)
                //    {
                //        DataListTop.Add(DataOne = new Person());
                //        DataListTop[1].Friends = DataListSecond;
                //    }
                //        return JsonConvert.SerializeObject(DataListTop);
                default:
                    return "";
            }

        }

        //public string PostData(string Name,string Age,string ContentType,Uri BaseURL)
        //{
        //    using(WebClient client=new WebClient())
        //    {
        //        client.Headers.Add(HttpRequestHeader.ContentType, ContentType);
        //        if (ContentType == "application/x-www-form-urlencoded")
        //        {
        //            return client.UploadString(BaseURL, QueryString(Name, Age));
        //        }
        //        else
        //        {
        //            Human PostDataJSON = new Human() { Name = Name, Age = Int32.Parse(Age) };
        //            return client.UploadString(BaseURL,JsonConvert.SerializeObject(PostDataJSON));
        //        }
        //    }
        //}
        public string PostData(string Data, string BaseURL, string ContentType,WebClient client)
        {
                client.Headers.Add(HttpRequestHeader.ContentType, ContentType);
                return client.UploadString(BaseURL, Data);
                    //if (ActionName == "SimpleModelBindingArray")
                    //{
                    //    string AgeArr = "";
                    //    for (int i = 0; i < Name.Count; i++)
                    //    {
                    //        AgeArr += $"Age={Age[i]}&";
                    //    }
                    //    string BaseURLAdd = BaseURL.AbsoluteUri + "?" + AgeArr.Substring(0, AgeArr.Length - 1);
                    //    Uri NewBaseURL = new Uri(BaseURLAdd);
                    //    return client.UploadString(NewBaseURL, QueryString(Name, Age, ActionName));
                    //}
                    //else
                    //{
                    //    return client.UploadString(BaseURL, QueryString(Name, Age, ActionName));
                    //}

                    //if (ActionName == "SimpleModelBindingArray")
                    //{
                    //    string AgeArr = "";
                    //    for (int i = 0; i < Name.Count; i++)
                    //    {
                    //        AgeArr += $"Age={Age[i]}&";
                    //    }
                    //    string BaseURLAdd = BaseURL.AbsoluteUri + "?" + AgeArr.Substring(0, AgeArr.Length - 1);
                    //    Uri NewBaseURL = new Uri(BaseURLAdd);
                    //    return client.UploadString(NewBaseURL, QueryString(Name, Age, ActionName));
                    //}
                    //else
                    //{
                    //    return client.UploadString(BaseURL, QueryString(Name, Age, ActionName));
                    //}
             
                    //if (ActionName == "SimpleModelBindingArrayJSON")
                    //{
                    //    string AgeArr = "";
                    //    for (int i = 0; i < Name.Count; i++)
                    //    {
                    //        AgeArr += $"Age={Age[i]}&";
                    //    }
                    //    string BaseURLAdd = BaseURL.AbsoluteUri + "?" + AgeArr.Substring(0, AgeArr.Length - 1);
                    //    Uri NewBaseURL = new Uri(BaseURLAdd);
                    //    return client.UploadString(NewBaseURL, QueryString(Name, Age, ActionName));
                    //}
                    //else
                    //{
                    //    return client.UploadString(BaseURL, QueryString(Name, Age, ActionName));
                    //}
                
            }
        }


    }


    public class RestSharpClient
    {

        public string Send(RestRequest request, Uri BaseURL)
        {
            var client = new RestClient(BaseURL);
            request.Method = Method.POST;
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
                    string NameArr = "";
                    for (int i = 0; i < Age.Count; i++)
                    {
                        //request.AddParameter(Test, Name[i]);
                        request.AddQueryParameter("Age", Age[i]);
                        NameArr += $"={Name[i]}&";
                    }
                    request.AddParameter(new Parameter("", NameArr.Substring(0,NameArr.Length-1), "application/x-www-form-urlencoded", ParameterType.RequestBody));
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
                case "SimpleModelBindingArrayJSON":
                    for (int i = 0; i < Age.Count; i++)
                    {
                        request.AddQueryParameter("Age", Age[i]);
                    }
                    request.AddJsonBody(Name);
                    break;
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

    public class WebApiConClient
    {
        public string QueryString(string Name,string Age,Uri BaseURL,string ContentType)
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