using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurguer.Ingredients.Contracts
{
    /// <summary>
    /// Exposes item information and its of ingredients
    /// </summary>
    public class ItemResponse
    {
        /// <summary>
        /// Item Identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List of Ingredients
        /// </summary>
        public IEnumerable<string> Ingredients { get; set; }
    }
}
