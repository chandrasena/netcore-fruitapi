using System.Collections.Generic;
using System.Linq;
using fruit_api.Models;

namespace fruit_api
{
    public class FruitService : IFruitService {
        private readonly FruitContext _context;
        public FruitService(FruitContext context)
        {
            _context = context;

            if (_context.FruitItems.Count() == 0)
            {
                _context.FruitItems.Add(new FruitItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        public IEnumerable<FruitItem> GetFruits()
        {
            return _context.FruitItems.ToList();    
        }
    }   
}