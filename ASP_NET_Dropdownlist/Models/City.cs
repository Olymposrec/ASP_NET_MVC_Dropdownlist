using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_Dropdownlist.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }

        public static List<City> GetFakeCities()
        {
            return new List<City>()
            {
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=0 },
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=1},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=2},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=3},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=4},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=5},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=6},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=7},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=8},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=9},
                    new City(){
                    CityId=FakeData.NumberData.GetNumber(1,15),
                    CityName=FakeData.PlaceData.GetCity(),
                    CountryId=10},
            };
        }
    }
}