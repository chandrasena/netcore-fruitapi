using System.Collections.Generic;
using System.Linq;
using fruit_api.Models;

namespace fruit_api
{
    public class FruitService : IFruitService {
        private readonly FruitContext _context;
        private readonly IRepository<FruitItem> _repository;

        public FruitService(FruitContext context, IRepository<FruitItem> repository)
        {
            _context = context;
            _repository = repository;

            if (_context.FruitItems.Count() == 0)
            {
                _context.FruitItems.Add(new FruitItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        public IEnumerable<FruitItem> GetFruits()
        {
            return _repository.GetAll(); //_context.FruitItems.ToList();    
        }
    }   
}