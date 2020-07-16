using ASP_NET_Dropdownlist.Models;
using ASP_NET_Dropdownlist.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_Dropdownlist.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            //SelectList selectListCity = new SelectList(City.GetFakeCities(), "CityId", "CityName");
            //SelectList selectListCountry = new SelectList(Country.GetFakeCountry(), "CountryId", "CountryName");

            //ViewBag.CitiesData = selectListCity;
            //ViewBag.CountriesData = selectListCountry;
            HomepageViewModel homepageViewModel = new HomepageViewModel()
            {
                CitiesData=new SelectList(City.GetFakeCities(),"CityId","CityName"),
                CountriesData=new SelectList(Country.GetFakeCountry(),"CountryId","CountryName"),
                SelectedCityId=-1,
                SelectedCountryId=-1

            };
            return View(homepageViewModel);
        }
        [HttpPost]
        public ActionResult Homepage(HomepageViewModel homepageVieModel)
        {
            //ViewBag.SelectedCityId = SelectedCityId;
            //ViewBag.SelectedCountryId = SelectedCountryID;

            //SelectList selectListCity = new SelectList(City.GetFakeCities(), "CityId", "CityName");
            //SelectList selectListCountry = new SelectList(Country.GetFakeCountry(), "CountryId", "CountryName");

            //ViewBag.CitiesData = selectListCity;
            //ViewBag.CountriesData = selectListCountry;
            homepageVieModel.CitiesData = new SelectList(City.GetFakeCities(), "CityId", "CityName");
            homepageVieModel.CountriesData = new SelectList(Country.GetFakeCountry(), "CountryId", "CountryName");

            return View(homepageVieModel);
        }
        public JsonResult GetCitiesByCountry(int id)
        {
            int countryId = id;

            List<City> result = City.GetFakeCities().Where(x => x.CountryId == countryId).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}