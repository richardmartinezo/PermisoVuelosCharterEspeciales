using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermisoVuelosCharterEspeciales.Models
{
    public class informacion_aeronave
    {
        public int? Id { get; set; }
        public int? permiso_vuelos_id { get; set; }
        public string? marca { get; set; }
        public string? tipo { get; set; }
        public string? matricula { get; set; }
        public int? mtow { get; set; }
    }
}
