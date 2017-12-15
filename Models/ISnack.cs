using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System.ComponentModel.DataAnnotations;
namespace OdeToFood.Models
{
    public interface ISnack
    {
        int Rating { get; set; }
        int Id { get; set; }

        [Display(Name="Snack Flavor")]
        [Required, MaxLength(80)] //Using attributes for client side validation
        string Flavor { get; set; }
        SnackType SnackType { get; set; }

    }
}
