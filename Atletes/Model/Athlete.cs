using System;
using System.Collections.Generic;

namespace Atletes.Model;

public partial class Athlete
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public int IdCategory { get; set; }

    public int IdLevelOfTraining { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual LevelsOfTraining IdLevelOfTrainingNavigation { get; set; } = null!;

    public virtual ICollection<Participation> Participations { get; set; } = new List<Participation>();
}
