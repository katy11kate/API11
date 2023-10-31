using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class StatusChange
{
    public int IdChange { get; set; }

    public int? IdStatus { get; set; }

    public DateTime? DateChange { get; set; }

    public virtual Status? IdStatusNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
