﻿using System;
using System.Collections.Generic;

namespace Atletes.Model;

public partial class Type
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Training> Training { get; set; } = new List<Training>();
}
