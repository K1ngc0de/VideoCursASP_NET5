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
                new Restaurant() {ID = 1, StarMishlen = "Yes", Name = "Pitta", Cuisine = CuisineType.Italian},
                new Restaurant() {ID = 2, StarMishlen = "No", Name = "Napoleon", Cuisine = CuisineType.French},
                new Restaurant() {ID = 3, StarMishlen = "No", Name = "Elef", Cuisine = CuisineType.Indian},
                new Restaurant() {ID = 4, StarMishlen = "Yes", Name = "Bear", Cuisine = CuisineType.Russian}
            };
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.ID = restaurants.Max(r => r.ID) + 1;
        }

        public Restaurant Get(int id)
        {
           return restaurants.FirstOrDefault(r => r.ID == id); 
        }


        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);   
        }
    }
}
