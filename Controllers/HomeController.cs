using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using System.Collections.Generic;
using OdeToFood.ViewModels;
namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        readonly IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _greeter = greeter;
            _restaurantData = restaurantData;

        }

        public IActionResult Index() //ActionResult doesn't immediately send stuff back to the cliet
        {
            //Returns content, ASP.NET Core would then later decide what to do with that content.
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();
                
            return View(model); //View will look for the same name as Index unless specified
            //return new ObjectResult(model); //ObjectResult tries to figure out client request and serializes object as needed
        }

        //Anything passed in after the url in the action section will be passed as int id
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        //This Action returns the view for creating a restaurant to the browser
        //Add route constrants to remove ambigous Create call
        [HttpGet]
        public IActionResult Create()
        {
            return View();   //View automatically looks for Create.cshtml
        }

        //This Actions accepts a post request from the Create View 
        [HttpPost] //Add route cosntraint for httpPost Create request
        public IActionResult Create(RestaurantEditModel model)
        {
            if(ModelState.IsValid)//ModelState is a framework property that checks your POST bindings
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Name = model.Name;
                newRestaurant.Cuisine = model.Cuisine;  //uses POST - REDIRECT - GET Pattern, POST is for write, GET is for read

                newRestaurant = _restaurantData.Add(newRestaurant);
                //return View("Details", newRestaurant); //Used for POST request 

                return RedirectToAction(nameof(Details), new { id = newRestaurant.Id }); //This redirect action makes it POST safe
            }
            else
            {
                return View();
            }

        }
    }
}
