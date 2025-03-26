using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test20250326.AppWebMVC.Models;

public partial class Warehouse
{
    public int Id { get; set; }
    [Display(Name = "Nombre")]
    public string WarehouseName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
