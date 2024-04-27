using System;
using System.Collections.Generic;

namespace PeruApi.Data;

public partial class Product
{
    public int Id { get; set; }

    public string? Descriptions { get; set; }

    public decimal? UnitPrice { get; set; }

    public bool? IsActive { get; set; }
}
