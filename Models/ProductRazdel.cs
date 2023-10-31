using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class ProductRazdel
{
    public int IdproductRazdel { get; set; }

    public string? NameRazdel { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
