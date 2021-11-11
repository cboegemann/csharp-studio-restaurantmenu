using System;
using System.Collections.Generic;

namespace csharp_studio_restaurantmenu
{
    public class Menu
    {
        public Dictionary<string, double> MenuItems = new Dictionary<string, double>
        {

        };
        public DateTime LastUpdate { get; set; }
    }
}
