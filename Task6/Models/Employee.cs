using System;
using System.Collections.Generic;

namespace Task6.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Job { get; set; }

    public decimal? Salary { get; set; }

    public byte[]? Photo { get; set; }
}
