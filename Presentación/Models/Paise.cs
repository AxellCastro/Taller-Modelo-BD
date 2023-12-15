using System;
using System.Collections.Generic;

namespace Presentación.Models;

public partial class Paise
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Ciudade> Ciudades { get; } = new List<Ciudade>();
}
