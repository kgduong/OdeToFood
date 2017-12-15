using System;
using OdeToFood.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using OdeToFood.Models.Chip;
namespace OdeToFood.ViewModels
{
    public class ChipEditModel
    {
        //Properties here matches the name of the field of your form: Create.cshtml
        [Required, MaxLength(80)]
        public string Flavor { get; set; }
        public ChipType ChipType { get; set; }
    }
}
