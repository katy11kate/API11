﻿using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public string? Barcode { get; set; }

    public string? NameProduct { get; set; }

    public int? IdCategory { get; set; }

    public int? IdRazdel { get; set; }

    public int? IdProvider { get; set; }

    public string? Description { get; set; }

    public int? Cost { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public virtual ICollection<Consignmentlist> Consignmentlists { get; set; } = new List<Consignmentlist>();

    public virtual ProductCategory? IdCategoryNavigation { get; set; }

    public virtual Provider? IdProviderNavigation { get; set; }

    public virtual ProductRazdel? IdRazdelNavigation { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<Orderlist> Orderlists { get; set; } = new List<Orderlist>();

    public virtual ProductAvailability? ProductAvailability { get; set; }
}
