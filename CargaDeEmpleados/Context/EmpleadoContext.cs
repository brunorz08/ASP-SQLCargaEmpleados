using CargaDeEmpleados.Models;
using Microsoft.EntityFrameworkCore;

namespace CargaDeEmpleados.Context
{
    public class EmpleadoContext : DbContext
    {

        public virtual DbSet<Empleado> Empleados { get; set;}
        public EmpleadoContext(DbContextOptions<EmpleadoContext> options) : base(options)
        {

        }

       
    }
}
