﻿using ETrade.Core;
using ETrade.Dal;
using ETrade.DTO;
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

        public List<CategoriesDTO> GetCategories()
        {
            return Set().Select(x => new CategoriesDTO
            {
                // sol taraf ProductDTO sağ taraf Products
                Id = x.CategoryId,
                CategoryName = x.CategoryName,

                // public string CategoryName { get; set; }
                // public ICollection<Foods> Foods { get; set; }

            }).ToList();
        }
    }
}
