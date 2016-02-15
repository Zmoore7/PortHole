using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace json.Models
{
    [Serializable]
    public class car
    {
  
        public int year { get; set; }
        public string model { get; set; }
        public string make { get; set; }
        public string vin { get; set; }

    }
}