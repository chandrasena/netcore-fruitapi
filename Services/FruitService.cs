using System.Collections.Generic;
using System.Linq;
using fruit_api.Models;

namespace fruit_api
{
    public class FruitService : IFruitService {
        //private readonly FruitContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public FruitService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Fruit> GetFruits()
        {
            return _unitOfWork.FruitRepository.GetAll(); //_context.FruitItems.ToList();    
        }
    }   
}