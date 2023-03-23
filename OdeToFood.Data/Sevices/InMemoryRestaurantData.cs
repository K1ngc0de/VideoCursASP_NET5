using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Sevices
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant() {ID = 1, Name = "Pitta", Cuisine = CuisineType.Italian},
                new Restaurant() {ID = 2, Name = "Napoleon", Cuisine = CuisineType.French},
                new Restaurant() {ID = 3, Name = "Pitta", Cuisine = CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);   
        }
    }
}
