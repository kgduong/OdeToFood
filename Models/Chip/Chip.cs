using System;
using OdeToFood.Models.Chip;
namespace OdeToFood.Models.Chip
{
    public class Chip : ISnack
    {
        public SnackType SnackType { get; set; }
        public string Flavor { get; set; }
        public int Rating { get; set; }
        public ChipType ChipType { get; set; }
        public int Id { get; set; }
    }
}
