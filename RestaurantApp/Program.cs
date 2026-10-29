using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Restaurant
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public double Rating { get; set; }

        public Restaurant(string id, string name, string type, double rating)
        {
            Id = id;
            Name = name;
            Type = type;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} ({Type}) - คะแนน: {Rating}/5";
        }
        List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
        };

    }
}

    

