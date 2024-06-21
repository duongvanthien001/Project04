using System;
using System.Collections.Generic;

namespace Project04.Models;

public partial class Order
{
    public int Id { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal TotalPrice { get; set; }

    public string? Note { get; set; }

    public int CustomerId { get; set; }

    public int ShippingAddressId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User Customer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ShippingAddress ShippingAddress { get; set; } = null!;
}
