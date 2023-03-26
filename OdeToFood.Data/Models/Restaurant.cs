﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(3)]
        public string StarMishlen { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name = "Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}
