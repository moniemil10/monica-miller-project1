﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWeb1.Models
{
    public class ReviewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int rating { get; set; }
        public string review { get; set; }
    }
}