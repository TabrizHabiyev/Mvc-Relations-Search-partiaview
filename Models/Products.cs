using System;
using System.Collections.Generic;

namespace Select_Option_Relations.Models
{
    public class CarModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CarBrand> carBrands { get; set; }

    }
}
