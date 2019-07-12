﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectForecast_OA.Models
{
    public class Consultant_CostRate
    {
        [Key]
        public int Consultant_ID { get; set; }
        public string UpdatedTime{ get; set; }
        public int CostRate { get; set; }
    }
}