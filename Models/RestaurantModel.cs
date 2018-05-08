using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantWeb1.Models
{
    public class RestaurantModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Requires name")]
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public int AvgRating { get; set; }
    }
}