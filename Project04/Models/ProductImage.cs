using System;
using System.Collections.Generic;

namespace Project04.Models;

public partial class ProductImage
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
