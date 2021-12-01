using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PermisoVuelosCharterEspeciales.Models;

namespace PermisoVuelosCharterEspeciales.Data
{
    public class PermisoVuelosCharterEspecialesContext : DbContext
    {
        public PermisoVuelosCharterEspecialesContext (DbContextOptions<PermisoVuelosCharterEspecialesContext> options)
            : base(options)
        {
        }

        public DbSet<PermisoVuelosCharterEspeciales.Models.permisos_vuelo> permisos_vuelo { get; set; }
        public DbSet<PermisoVuelosCharterEspeciales.Models.tipo_permiso> tipo_Permiso { get; set; }
        public DbSet<PermisoVuelosCharterEspeciales.Models.forma_pago> forma_pago { get; set; }
        public DbSet<PermisoVuelosCharterEspeciales.Models.informacion_aeronave> informacion_aeronave { get; set; }


    }
}
