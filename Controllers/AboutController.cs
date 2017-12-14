using System;
using Microsoft.AspNetCore.Mvc;
namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        
        public string Phone()
        {
            return "626 + 417";
        }

        public string Address()
        {
            return "USA";
        }
    }
}
