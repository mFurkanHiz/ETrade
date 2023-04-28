﻿using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class CategoryRepository : BaseRepository<Categories>, ICategoryRepository
    {
        public CategoryRepository(Context context) : base(context)
        {

        }
    }
}
