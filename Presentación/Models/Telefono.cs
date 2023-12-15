using System;
using System.Collections.Generic;

namespace Presentación.Models;

public partial class Telefono
{
    public int Id { get; set; }

    public string Numero { get; set; } = null!;

    public int PersonaId { get; set; }

    public virtual Persona Persona { get; set; } = null!;
}
