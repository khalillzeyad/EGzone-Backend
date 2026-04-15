using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Seller? Seller { get; set; }

    public string Role { get; set; } = "Customer";

}
