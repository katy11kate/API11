using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class Consignment
{
    public int IdConsignment { get; set; }

    public int? IdProvider { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? ResponsibleEmployee { get; set; }

    public virtual Consignmentlist? Consignmentlist { get; set; }

    public virtual Provider? IdProviderNavigation { get; set; }

    public virtual Employee? ResponsibleEmployeeNavigation { get; set; }
}
