using System;
using System.Collections.Generic;

namespace GeekBurger.Dashboard.Contract
{
    public class UsersWithLessOffer
    {
        public int Users { get; set; }
        public IEnumerable<string> Restrictions { get; set; }

    }
}
