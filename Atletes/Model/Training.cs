using System;
using System.Collections.Generic;

namespace Atletes.Model;

public partial class Training
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateOnly Date { get; set; }

    public short Time { get; set; }

    public int IdType { get; set; }

    public virtual Type IdTypeNavigation { get; set; } = null!;

    public virtual ICollection<Participation> Participations { get; set; } = new List<Participation>();
}
