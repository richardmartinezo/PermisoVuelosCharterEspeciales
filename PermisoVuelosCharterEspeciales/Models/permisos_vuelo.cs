using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermisoVuelosCharterEspeciales.Models
{
    public class permisos_vuelo
    {
        public int Id { get; set; }
        public string tipo_solicitud { get; set; }
        public int num_solicitud { get; set; }
        public int num_vuelos_solicitados { get; set; }
        public DateTime fecha { get; set; }
        public string cod_oaci { get; set; }
        public string cedula_ruc { get; set; }
        public string telefono { get; set; }
        public string fax { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string vigencia_seguro { get; set; }
        public string proposito_vuelo { get; set; }
        public bool pasajeros { get; set; }
        public int num_pasajeros { get; set; }
        public string carga { get; set; }
        public string nombre_fletador { get; set; }
        public string telefono_fletador { get; set; }
        public string fax_fletador { get; set; }
        public string direccion_fletador { get; set; }
        public string email_fletador { get; set; }
        public string permiso_operador { get; set; }
        public string especificaciones_operacionales { get; set; }
        public string forma_pago { get; set; }
        public string observaciones { get; set; }
        public string nombre_representante { get; set; }
        public string detalle_vuelo_complementado { get; set; }
    }
}
