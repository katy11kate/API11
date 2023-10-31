using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class Image
{
    public int IdImage { get; set; }

    public int? IdProduct { get; set; }

    public string? Image1 { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
