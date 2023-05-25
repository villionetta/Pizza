using System;
using System.Collections.Generic;

namespace Pizzeria;

public partial class Pizza
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Ingredients { get; set; } = null!;

    public double Weight { get; set; }

    public double Price { get; set; }

    public byte[]? Picture { get; set; }
}
