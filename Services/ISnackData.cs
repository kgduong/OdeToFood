using System;
using System.Collections.Generic;
using OdeToFood.Models;
namespace OdeToFood.Services
{
    public interface ISnackData
    {
        IEnumerable<ISnack> GetAll();
        ISnack Get(int id);
        ISnack Add(ISnack restaurant);
    }
}
