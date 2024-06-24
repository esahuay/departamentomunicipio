using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace departamentomunicipio.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            Tablapais = new HashSet<Tablapai>();
        }

        public int Id { get; set; }
        public int DepartamentoId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Departamento Departamento { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<Tablapai> Tablapais { get; set; }
    }
}
