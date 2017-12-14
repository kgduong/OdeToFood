using System;
using OdeToFood.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace OdeToFood.ViewModels
{
    public class RestaurantEditModel
    {
        //Properties here matches the name of the field of your form: Create.cshtml
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
