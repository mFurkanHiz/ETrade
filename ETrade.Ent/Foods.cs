﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class Foods : Base
    {
        public string FoodName { get; set; }
        public Guid CategoryId { get; set; }
        public Guid PropertyId { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public ICollection<Properties> properties { get; set; }
        public ICollection<Categories> Categories { get; set; }
    }
}
