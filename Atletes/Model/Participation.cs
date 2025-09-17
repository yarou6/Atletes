using System;
using System.Collections.Generic;

namespace Atletes.Model;

public partial class Participation
{
    public int Id { get; set; }

    public int IdTraining { get; set; }

    public int IdAthlet { get; set; }

    public virtual Athlete IdAthletNavigation { get; set; } = null!;

    public virtual Training IdTrainingNavigation { get; set; } = null!;

    public virtual ICollection<Progress> Progresses { get; set; } = new List<Progress>();
}
