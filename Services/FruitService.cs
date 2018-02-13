using System;
using System.Collections.Generic;
using System.Linq;
using fruit_api.Models;
using log4net;
//using log4net.Core;

namespace fruit_api
{
    public class FruitService : IFruitService {
        //private readonly FruitContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILog _logger;

        public FruitService(IUnitOfWork unitOfWork, ILog logger) //, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IEnumerable<Fruit> GetFruits()
        {
            _logger.Info("hello", new Exception("hello"));
            return _unitOfWork.FruitRepository.GetAll(); //_context.FruitItems.ToList();    
        }
    }   
}