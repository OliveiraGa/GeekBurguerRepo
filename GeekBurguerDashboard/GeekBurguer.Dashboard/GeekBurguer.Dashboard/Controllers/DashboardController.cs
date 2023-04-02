using GeekBurger.Dashboard.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GeekBurger.Dashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {
        private IList<Sales> SalesList = new List<Sales>();
        private IList<UsersWithLessOffer> UsersWithLessOffersList = new List<UsersWithLessOffer>();

        public DashboardController()
        {
            SalesList.Add(new Sales { StoreName = "Paulista", Number = 10, Value = "4092.00" });
            UsersWithLessOffersList.Add(new UsersWithLessOffer { Users = 1, Restrictions = new List<string> { "soy, dairy, peanut" } });
            UsersWithLessOffersList.Add(new UsersWithLessOffer { Users = 2, Restrictions = new List<string> { "soy, dairy" } });
        }

        [HttpGet("/sales")]
        public IActionResult GetSales()
        {
            if (SalesList.Count() == 0)
                return NotFound();

            return Ok(SalesList);
        }

        [HttpGet("/UsersWithLessOffer")]
        public IActionResult GetUsersWithLessOffer()
        {
            if (UsersWithLessOffersList.Count() == 0)
                return NotFound();

            return Ok(UsersWithLessOffersList);
        }
    }
}
