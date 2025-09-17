using System;
using System.Collections.Generic;

namespace Atletes.Model;

public partial class Progress
{
    public int Id { get; set; }

    public short Grade { get; set; }

    public string Comment { get; set; } = null!;

    public int IdParticipation { get; set; }

    public virtual Participation IdParticipationNavigation { get; set; } = null!;
}
