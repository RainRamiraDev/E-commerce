using System;
using System.Collections.Generic;

namespace EC_App.Models;

public partial class UserAddress
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string AddressLine { get; set; } = null!;

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public bool? IsDefault { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual User User { get; set; } = null!;
}
