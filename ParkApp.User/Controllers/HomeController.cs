using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using ParkApp.User.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParkApp.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(ILogger<HomeController> logger,IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var cultureInfo = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            var say_hello_value = _localizer["Say_Hello"];



            //var client = new MongoClient("mongodb+srv://ahmet_kecici_42:GkuasQnITKGGUYQW@cluster0.ltyer.mongodb.net/CarParkDb?retryWrites=true&w=majority");
            //var database = client.GetDatabase("CarParkDb");
            //var collection = database.GetCollection<Test>("Test");


            //var test = new Test
            //{
            //    _Id = ObjectId.GenerateNewId(),
            //    NameSurname="Ahmet ",
            //     Age=11,
            //     Adress=new List<Adres> { 
            //         new Adres { Title="ev",Description="bakkalı dönünce orda"},
            //        new Adres { Title="iş",Description="marketi  dönünce orda"},
            //     }
            //};
            //collection.InsertOne(test);

                var musteri = new Customer
            {
                Id=1,
                NameSurname="ayşenur keçici",
                Age=11
            };

            _logger.LogInformation("Customer da hata {@customer}",musteri);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
