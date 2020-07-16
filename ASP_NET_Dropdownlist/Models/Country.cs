using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_Dropdownlist.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public static List<Country> GetFakeCountry()
        {
            
            return new List<Country>()
            {
                    new Country(){
                    CountryId=1,
                    CountryName=FakeData.PlaceData.GetCountry(),
                     },
                    new Country(){
                    CountryId=2,
                    CountryName=FakeData.PlaceData.GetCountry(),
                    },
                    new Country(){
                    CountryId=3,
                    CountryName=FakeData.PlaceData.GetCountry(),
                    },
                    new Country(){
                    CountryId=4,
                    CountryName=FakeData.PlaceData.GetCountry(),
                    },
                    new Country(){
                    CountryId=5,
                    CountryName=FakeData.PlaceData.GetCountry(),
                   },
                    new Country(){
                    CountryId=6,
                    CountryName=FakeData.PlaceData.GetCountry(),
                    },
                    new Country(){
                   CountryId=7,
                    CountryName=FakeData.PlaceData.GetCountry(),
                   },
                    new Country(){
                    CountryId=8,
                    CountryName=FakeData.PlaceData.GetCountry(),
                    },
                    new Country(){
                    CountryId=9,
                    CountryName=FakeData.PlaceData.GetCountry(),
                    },
                    new Country(){
                    CountryId=10,
                    CountryName=FakeData.PlaceData.GetCountry(),
                    },
                    new Country(){
                    CountryId=0,
                    CountryName=FakeData.PlaceData.GetCountry(),
                    }
            };
        }
    }
}