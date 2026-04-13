using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Models;

public partial class Coupon
{
    public int CouponId { get; set; }

    public string? Code { get; set; }

    public int? DiscountPercent { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? MaxUsage { get; set; }

    public int? UsedCount { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
