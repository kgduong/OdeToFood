using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ISnack> Snacks { get; set; }
        public string CurrentMessage { get; set; }
    }
}
