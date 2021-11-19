using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermisoVuelosCharterEspeciales.Models
{
    public class Validador_Nulos
    {
        private permisos_vuelo permisos_Vuelo;
       
        public permisos_vuelo permiso_validado(permisos_vuelo permisos_Vuelo) {
            this.permisos_Vuelo = new permisos_vuelo();
            this.permisos_Vuelo = permisos_Vuelo;
           
            if (this.permisos_Vuelo.tipo_solicitud==(null)) {
                this.permisos_Vuelo.tipo_solicitud = "";
            }
            if (this.permisos_Vuelo.num_solicitud==0)
            {
                this.permisos_Vuelo.num_solicitud = 0;
            }
            if (this.permisos_Vuelo.num_vuelos_solicitados==0)
            {
                this.permisos_Vuelo.num_vuelos_solicitados = 0;
            }
            if (this.permisos_Vuelo.fecha == null)
            {
                this.permisos_Vuelo.fecha = DateTime.Now;
            }
            if (this.permisos_Vuelo.cod_oaci==(null))
            {
                this.permisos_Vuelo.cod_oaci = "";
            }
            if (this.permisos_Vuelo.cedula_ruc==(null))
            {
                this.permisos_Vuelo.cedula_ruc = "";
            }
            if (this.permisos_Vuelo.telefono==(null))
            {
                this.permisos_Vuelo.telefono = "";
            }
            if (this.permisos_Vuelo.fax==(null))
            {
                this.permisos_Vuelo.fax = "";
            }
            if (this.permisos_Vuelo.direccion==(null))
            {
                this.permisos_Vuelo.direccion = "";
            }
            if (this.permisos_Vuelo.email==(null))
            {
                this.permisos_Vuelo.email = "";
            }
            if (this.permisos_Vuelo.vigencia_seguro==(null))
            {
                this.permisos_Vuelo.vigencia_seguro = "";
            }
            if (this.permisos_Vuelo.proposito_vuelo==(null))
            {
                this.permisos_Vuelo.proposito_vuelo = "";
            }
            if (this.permisos_Vuelo.num_pasajeros==0)
            {
                this.permisos_Vuelo.num_pasajeros = 0;
            }
            if (this.permisos_Vuelo.tipo_solicitud==(null))
            {
                this.permisos_Vuelo.tipo_solicitud = "";
            }
            if (this.permisos_Vuelo.nombre_fletador==(null))
            {
                this.permisos_Vuelo.nombre_fletador = "";
            }
            if (this.permisos_Vuelo.telefono_fletador==(null))
            {
                this.permisos_Vuelo.telefono_fletador = "";
            }
            if (this.permisos_Vuelo.fax_fletador==(null))
            {
                this.permisos_Vuelo.fax_fletador = "";
            }
            if (this.permisos_Vuelo.direccion_fletador==(null))
            {
                this.permisos_Vuelo.direccion_fletador = "";
            }
            if (this.permisos_Vuelo.email_fletador==(null))
            {
                this.permisos_Vuelo.email_fletador = "";
            }
            if (this.permisos_Vuelo.forma_pago==(null))
            {
                this.permisos_Vuelo.forma_pago= "";
            }
            if (this.permisos_Vuelo.observaciones==(null))
            {
                this.permisos_Vuelo.observaciones = "";
            }
            if (this.permisos_Vuelo.nombre_representante==(null))
            {
                this.permisos_Vuelo.nombre_representante = "";
            }
            if (this.permisos_Vuelo.detalle_vuelo_complementado==(null))
            {
                this.permisos_Vuelo.detalle_vuelo_complementado = "";
            }
            if (this.permisos_Vuelo.carga==(null))
            {
                this.permisos_Vuelo.carga = false;
            }
            if (this.permisos_Vuelo.pasajeros==(null))
            {
                this.permisos_Vuelo.pasajeros = false;
            }
            if (this.permisos_Vuelo.permiso_operador==(null))
            {
                this.permisos_Vuelo.permiso_operador = false;
            }
            if (this.permisos_Vuelo.especificaciones_operacionales==(null))
            {
                this.permisos_Vuelo.especificaciones_operacionales = false;
            }

            return this.permisos_Vuelo;

        }




    }
}
