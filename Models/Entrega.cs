using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace apisaude.Models;

public partial class Entrega
{
    public int CodEntrega { get; set; }

    public int CodPaciente { get; set; }

    public int CodMatmed { get; set; }

    public DateOnly? DataEntrega { get; set; }

    public DateOnly? DataProEntrega { get; set; }

    [JsonIgnore]
    public virtual MatMed? CodMatmedNavigation { get; set; }
    [JsonIgnore]
    public virtual Paciente? CodPacienteNavigation { get; set; }
}
