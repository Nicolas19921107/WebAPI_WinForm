﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class HomeController : ApiController
    {
        /// <summary>
        /// ModelBindingObj
        /// </summary>
        /// <remarks>測試 Obj 的 ModelBinding </remarks>
        /// <param name="data">Human 內的 Name 與 Age 屬性</param>
        /// <returns>123</returns>
        /// <response code="200">回傳成功</response>
        [HttpPost]
        [ResponseType(typeof(Human))]
        //[Route("api/Home/ModelBindObj")]
        public IHttpActionResult ModelBindObj(Human data)
        {
            switch (Request.Content.Headers.ContentType.ToString())
            {
                case "application/x-www-form-urlencoded":
                    return Ok(nameof(data.Name) + ":" + data.Name + ", " + nameof(data.Age) + ":" + data.Age);
                default:
                    break;
            }
            return Ok(data);
        }

        /// <summary>
        /// ModelBindingArray
        /// </summary>
        /// <remarks>測試 Array 的 ModelBinding </remarks>
        /// <param name="data">Human 類別，裡面有 Name 與 Age 屬性組成的陣列</param>
        /// <returns>123</returns>
        /// <response code="200">回傳成功</response>
        [HttpPost]
        [ResponseType(typeof(Human[]))]
        //[Route("api/Home/ModelBindingArray")]
        public IHttpActionResult ModelBindingArray(Human[] data)
        {
            return Ok(data);
        }

        /// <summary>
        /// ModelBindingNestedObj
        /// </summary>
        /// <remarks>測試 Obj 的 ModelBindingNestedArray </remarks>
        /// <param name="data">Person 內有個 Friend 集合，裡面有 Name 與 Age 屬性</param>
        /// <returns>123</returns>
        /// <response code="200">回傳成功</response>
        [HttpPost]
        [ResponseType(typeof(Person))]
        //[Route("api/Home/ModelBindingNestedObj")]
        public IHttpActionResult ModelBindingNestedObj(Person data)
        {
            return Ok(data);
        }

        /// <summary>
        /// ModelBindingArrayNestedObj
        /// </summary>
        /// <remarks>測試 Obj 的 ModelBindingNestedArray </remarks>
        /// <param name="data">Person 陣列，內有 Friend 集合，裡面有 Name 與 Age 屬性</param>
        /// <returns>123</returns>
        /// <response code="200">回傳成功</response>
        [HttpPost]
        [ResponseType(typeof(Person[]))]
        //[Route("api/Home/ModelBindingArrayNestedObj")]
        public IHttpActionResult ModelBindingArrayNestedObj(Person[] data)
        {
            return Ok(data);
        }

        /// <summary>
        /// SimpleBinding
        /// </summary>
        /// <remarks>測試 SimpleBinding </remarks>
        /// <param name="data">Human 類別，裡面有 Name 與 Age 屬性</param>
        /// <returns>123</returns>
        /// <response code="200">回傳成功</response>
        [HttpPost]
        [ResponseType(typeof(Human))]
        //[Route("api/Home/SimpleBinding")]
        public IHttpActionResult SimpleBinding([FromBody]Human data)
        {
            switch (Request.Content.Headers.ContentType.ToString())
            {
                case "application/x-www-form-urlencoded":
                    return Ok(nameof(data.Name) + ":" + data.Name + ", " + nameof(data.Age) + ":" + data.Age);
                default:
                    break;
            }
            return Ok(data);
        }

        /// <summary>
        /// SimpleModelBindArray
        /// </summary>
        /// <remarks>測試 Array 的 SimpleBinding </remarks>
        /// <param name="data"> Name 與 Age 組成的陣列</param>
        /// <returns>123</returns>
        /// <response code="200">回傳成功</response>
        [HttpPost]
        //[Route("api/Home/SimpleModelBindArray")]
        public IHttpActionResult SimpleModelBindArray([FromUri]string[] Name,int[] Age)
        {
            string str = nameof(Name) + ":";
            foreach (string n in Name)
            {
                str += n + ",";
            }
            str = str.Substring(0, str.Length - 1);
            str += " | ";
            str += nameof(Age) + ":";
            foreach (int a in Age)
            {
                str += a + ",";
            }
            str = str.Substring(0, str.Length - 1);
            return Ok(str);
        }


    }
}