using System.Collections.Generic;
using Select_Option_Relations.Models;

namespace Select_Option_Relations.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<CarModel> carModels { get; set; }

        public IEnumerable<CarBrand> carBrands { get; set; }
    }
}
