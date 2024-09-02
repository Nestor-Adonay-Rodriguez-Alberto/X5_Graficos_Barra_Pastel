using Acceso_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio
{
    public class ReportesBL
    {
        // Objeto Representa DB:
        private readonly ReportesDAL _ReportesDAL;

        // Constructor:
        public ReportesBL(ReportesDAL reportesDAL)
        {
            _ReportesDAL = reportesDAL;
        }


        // ******* METODOS QUE MANDARAN OBJETOS A LAS VISTAS ********
        // **********************************************************

        // Lista De La Tabla Empleados Para ViewData:
        public async Task<List<Empleado>> Lista_Empleados()
        {
            return await _ReportesDAL.Lista_Empleados();
        }

        // Encuentra y Manda Los Objetos Con Ese Id:
        public async Task<List<Factura>> Facturas_Realizadas(int ID)
        {
            return await _ReportesDAL.Facturas_Realizadas(ID);
        }
    }
}
