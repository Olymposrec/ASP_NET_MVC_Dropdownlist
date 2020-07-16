using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_Dropdownlist.ViewModels
{
    public class HomepageViewModel
    {
        public int SelectedCityId { get; set; }
        public int SelectedCountryId { get; set; }
        public SelectList CitiesData { get; set; }
        public SelectList CountriesData { get; set; }
    }
}