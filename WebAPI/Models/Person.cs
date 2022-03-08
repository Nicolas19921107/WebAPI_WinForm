using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    /// <summary>
    /// Person 類別:繼承 Human
    /// </summary>
    public class Person : Human
    {
        /// <summary>
        /// Friends 為 Person 的集合
        /// </summary>
        public List<Person> Friends { get; set; }
    }
}