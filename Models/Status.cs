using System;
using System.Collections.Generic;

namespace RestfulAPI.Models;

public partial class Status
{
    public int IdStatus { get; set; }

    public string? NameStatus { get; set; }

    public virtual ICollection<StatusChange> StatusChanges { get; set; } = new List<StatusChange>();
}
