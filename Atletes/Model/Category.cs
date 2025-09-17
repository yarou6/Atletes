﻿using System;
using System.Collections.Generic;

namespace Atletes.Model;

public partial class Category
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();
}
