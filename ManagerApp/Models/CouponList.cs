﻿using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.Models
{
    public class CouponList : RealmObject
    {
        public IList<Coupon> coupons { get; }
    }
}
