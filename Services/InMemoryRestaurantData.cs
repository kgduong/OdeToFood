using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using OdeToFood.Models;
using System.Linq;
namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id = 1, Name = "Kyle's Bakery"},
                new Restaurant{Id = 2, Name = "Document Coffee Bar"},
                new Restaurant{Id = 3, Name = "Sun Nong Dan"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(x => x.Id) + 1;
            _restaurants.Add(restaurant);

            return restaurant;
        }
    }
}
