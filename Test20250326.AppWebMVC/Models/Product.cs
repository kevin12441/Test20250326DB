using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Test20250326.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }
    [Required(ErrorMessage = "El precio es obligatorio.")]
    public decimal Price { get; set; }
    [Display(Name = "Bodega")]
    public int? WarehouseId { get; set; }
    [Display(Name = "Marcas")]
    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
