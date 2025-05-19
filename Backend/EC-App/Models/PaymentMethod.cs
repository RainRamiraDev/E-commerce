using System;
using System.Collections.Generic;

namespace EC_App.Models;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public string MethodName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
