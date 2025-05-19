using System;
using System.Collections.Generic;

namespace EC_App.Models;

public partial class Order
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int? AddressId { get; set; }

    public int? PaymentMethodId { get; set; }

    public int? StatusId { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual UserAddress? Address { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual PaymentMethod? PaymentMethod { get; set; }

    public virtual OrderStatus? Status { get; set; }

    public virtual User User { get; set; } = null!;
}
