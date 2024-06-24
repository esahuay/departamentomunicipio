using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace departamentomunicipio.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Municipios = new HashSet<Municipio>();
            Tablapais = new HashSet<Tablapai>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<Municipio> Municipios { get; set; }
        [JsonIgnore]
        public virtual ICollection<Tablapai> Tablapais { get; set; }
    }
}
