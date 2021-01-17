using BussinesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer.Entities
{
    public class Product : BaseEntities
    {

        public string Name { get; set; }
        public string Slug { get; set; }
        public string FullName { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal StockAmount { get; set; }
        public decimal Discount { get; set; }
        public string PageTitle { get; set; }
        public string ShortDetails { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }

    }
}
