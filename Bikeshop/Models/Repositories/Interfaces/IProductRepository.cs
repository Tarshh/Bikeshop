using System.Collections;
using System.Collections.Generic;

namespace Bikeshop.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllBikes();
        Product GetBikeById(int bikeId);
    }
}