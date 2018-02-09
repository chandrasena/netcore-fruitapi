using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using fruit_api.Models;
using fruit_api.ViewModels;

namespace fruit_api
{
    public class FlowerService : IFlowerService {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FlowerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<FlowerViewModel> GetFlowers()
        {
            var viewModels = new List<FlowerViewModel>();

            var flowerModels =_unitOfWork.FlowerRepository.GetAll();  
            // convert
            foreach (var model in flowerModels) {
                try {
                    var viewModel = _mapper.Map<FlowerViewModel>(model);
                    viewModels.Add(viewModel);
                }
                catch (Exception ex) {
                    Console.WriteLine(ex);
                }
            }
            
            return viewModels.AsEnumerable(); 
        }
    }   
}