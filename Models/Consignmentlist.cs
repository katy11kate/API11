using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class Consignmentlist
{
    public int IdConsignmen { get; set; }

    public int? IdProduct { get; set; }

    public virtual Consignment IdConsignmenNavigation { get; set; } = null!;

    public virtual Product? IdProductNavigation { get; set; }
}
