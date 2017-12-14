using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System.ComponentModel.DataAnnotations;
namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant Name")]
        [Required, MaxLength(80)] //Using attributes for client side validation
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
