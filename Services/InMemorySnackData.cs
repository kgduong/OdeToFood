using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using OdeToFood.Models;
using System.Linq;
using OdeToFood.Models.Chip;
namespace OdeToFood.Services
{
    public class InMemorySnackData : ISnackData
    {
        private List<ISnack> _snacks;

        public InMemorySnackData()
        {
            _snacks = new List<ISnack>
            {
                new Chip{Rating = 1, Flavor = "Regular Potato", SnackType=SnackType.Chip, ChipType=ChipType.Lays, Id=0},
                new Chip{Rating = 1, Flavor = "Sweet Onion", SnackType=SnackType.Chip, ChipType=ChipType.Hawaiian, Id=0},
                new Chip{Rating = 1, Flavor = "Salted Caramel", SnackType=SnackType.Chip, ChipType=ChipType.Popcorn, Id=0}
            };
        }

        public IEnumerable<ISnack> GetAll()
        {
            return _snacks.OrderBy(r => r.SnackType);
        }

        public ISnack Get(int id)
        {
            return _snacks.FirstOrDefault(r => r.Id == id);
        }

        public ISnack Add(ISnack snack)
        {
            snack.Id = _snacks.Max(x => x.Id) + 1;
            _snacks.Add(snack);

            return snack;
        }
    }
}
