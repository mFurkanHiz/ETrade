﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class OrderDetails : Base
    {
        public Guid OrderId { get; set; }
        public Guid FoodId { get; set; }
    }
}
