﻿using OdeToFood.Data.Models;
using System.Collections.Generic;

namespace OdeToFood.Data.Sevices
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
