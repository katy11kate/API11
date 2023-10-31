using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class Warehouse
{
    public int IdWarehouse { get; set; }

    public string? WarehouseName { get; set; }

    public string? Adress { get; set; }

    public virtual ICollection<Orderlist> Orderlists { get; set; } = new List<Orderlist>();

    public virtual ICollection<ProductAvailability> ProductAvailabilities { get; set; } = new List<ProductAvailability>();
}
