using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurguer.Ingredients.Contracts
{
    /// <summary>
    /// Exposes product information and its of items
    /// </summary>
    public class ProductResponse
    {
        /// <summary>
        /// Product Identifier
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// List of Items
        /// </summary>
        public IEnumerable<ItemResponse> Items { get; set; }
    }
}
