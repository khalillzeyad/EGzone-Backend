using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Models;

public partial class Seller
{
    public int SellerId { get; set; }

    public string? StoreName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual User SellerNavigation { get; set; } = null!;
}
