using System;
using System.Collections.Generic;

namespace Presentación.Models;

public partial class Ciudade
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int PaisId { get; set; }

    public virtual ICollection<Direccione> Direcciones { get; } = new List<Direccione>();

    public virtual Paise Pais { get; set; } = null!;
}
