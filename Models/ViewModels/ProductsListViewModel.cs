using System.Collections.Generic;
using sportstore.Models;

namespace sportstore.Models.ViewModels {
    public class ProductsListViewModel {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}