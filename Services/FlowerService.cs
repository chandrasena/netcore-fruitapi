using System.Collections.Generic;
using System.Linq;
using fruit_api.Models;

namespace fruit_api
{
    public class FlowerService : IFlowerService {
        private readonly IUnitOfWork _unitOfWork;

        public FlowerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Flower> GetFlowers()
        {
            return _unitOfWork.FlowerRepository.GetAll(); //_context.FruitItems.ToList();    
        }
    }   
}