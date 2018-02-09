using System.Collections.Generic;
using fruit_api.ViewModels;

namespace fruit_api
{
    public interface IFlowerService {
        IEnumerable<FlowerViewModel> GetFlowers();
    }
    
}