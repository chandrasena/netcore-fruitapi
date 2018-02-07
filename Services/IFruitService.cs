using System.Collections.Generic;
using System.Linq;
using fruit_api.Models;

namespace fruit_api
{
    public interface IFruitService {
        IEnumerable<FruitItem> GetFruits();
    }
    
}