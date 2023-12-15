using System;
using System.Collections.Generic;

namespace Presentación.Models;

public partial class Direccione
{
    public int Id { get; set; }

    public string Calle { get; set; } = null!;

    public int Numero { get; set; }

    public int CiudadId { get; set; }

    public virtual Ciudade Ciudad { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; } = new List<Persona>();
}
