using System;
using System.Collections.Generic;

namespace Presentación.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Edad { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public int DireccionId { get; set; }

    public virtual Direccione Direccion { get; set; } = null!;

    public virtual ICollection<Telefono> Telefonos { get; } = new List<Telefono>();
}
