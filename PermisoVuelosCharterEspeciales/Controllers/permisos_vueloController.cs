using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PermisoVuelosCharterEspeciales.Data;
using PermisoVuelosCharterEspeciales.Models;

namespace PermisoVuelosCharterEspeciales.Controllers
{
    public class permisos_vueloController : Controller
    {
        private readonly PermisoVuelosCharterEspecialesContext _context;

        public permisos_vueloController(PermisoVuelosCharterEspecialesContext context)
        {
            _context = context;
        }

        // GET: permisos_vuelo
        public async Task<IActionResult> Index()
        {
            return View(await _context.permisos_vuelo.ToListAsync());
        }

        // GET: permisos_vuelo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permisos_vuelo = await _context.permisos_vuelo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (permisos_vuelo == null)
            {
                return NotFound();
            }

            return View(permisos_vuelo);
        }

        // GET: permisos_vuelo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: permisos_vuelo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,tipo_solicitud," +            
            "num_vuelos_solicitados,fecha,cod_oaci,cedula_ruc,telefono,fax,direccion," +
            "email,vigencia_seguro,proposito_vuelo,pasajeros,num_pasajeros," +
            "carga,nombre_fletador,telefono_fletador,fax_fletador," +
            "direccion_fletador,email_fletador,permiso_operador,especificaciones_operacionales," +
            "forma_pago,observaciones,nombre_representante,detalle_vuelo_complementado")] permisos_vuelo permisos_vuelo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(permisos_vuelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(permisos_vuelo);
        }

        // GET: permisos_vuelo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permisos_vuelo = await _context.permisos_vuelo.FindAsync(id);
            if (permisos_vuelo == null)
            {
                return NotFound();
            }
            return View(permisos_vuelo);
        }

        // POST: permisos_vuelo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,tipo_solicitud," +           
            "num_vuelos_solicitados,fecha,cod_oaci,cedula_ruc,telefono,fax,direccion," +
            "email,vigencia_seguro,proposito_vuelo,pasajeros,num_pasajeros,carga," +
            "nombre_fletador,telefono_fletador,fax_fletador,direccion_fletador," +
            "email_fletador,permiso_operador,especificaciones_operacionales,forma_pago," +
            "observaciones,nombre_representante,detalle_vuelo_complementado")] permisos_vuelo permisos_vuelo)
        {
            if (id != permisos_vuelo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(permisos_vuelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!permisos_vueloExists(permisos_vuelo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(permisos_vuelo);
        }

        // GET: permisos_vuelo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permisos_vuelo = await _context.permisos_vuelo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (permisos_vuelo == null)
            {
                return NotFound();
            }

            return View(permisos_vuelo);
        }

        // POST: permisos_vuelo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var permisos_vuelo = await _context.permisos_vuelo.FindAsync(id);
            _context.permisos_vuelo.Remove(permisos_vuelo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool permisos_vueloExists(int id)
        {
            return _context.permisos_vuelo.Any(e => e.Id == id);
        }
    }
}
