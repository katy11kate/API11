using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class ProductCategory
{
    public int IdproductCategory { get; set; }

    public string? NameCategory { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
