using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace departamentomunicipio.Models
{
    public partial class Tablapai
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdDepartamento { get; set; }
        public int IdMunicipio { get; set; }

        [JsonIgnore]
        public virtual Departamento? IdDepartamentoNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual Municipio? IdMunicipioNavigation { get; set; } = null!;
    }
}
