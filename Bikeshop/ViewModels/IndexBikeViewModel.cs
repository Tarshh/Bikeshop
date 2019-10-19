using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bikeshop.Models;

namespace Bikeshop.ViewModels
{
    public class IndexBikeViewModel
    {
        public string Title { get; set; }
        public List<Product> Products { get; set; }

    }
}
