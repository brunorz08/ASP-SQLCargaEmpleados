using CargaDeEmpleados.Context;

namespace CargaDeEmpleados.Models
{
    public class ListadoEmpleados
    {
        private readonly EmpleadoContext context;

        public ListadoEmpleados(EmpleadoContext contx)
        {
            context = contx;
        }


        public List<Empleado> obtenerEmpleados()
        {
            return context.Empleados.ToList();
        }


        public Empleado obtenerEmpleado(int id)
        {
            var empleado = context.Empleados.Find(id);
            return empleado;

        }

        public void BorrarEmpleado(int id)
        {
            var empleado = context.Empleados.Find(id);
            if (empleado != null)
            {
                context.Empleados.Remove(empleado);
                context.SaveChanges();
            }
        }

        public void InsertarEmpleado(Empleado empleado)
        {

            var nuevoEmpleado = new Empleado()
            {
                nombre = empleado.nombre,
                edad = empleado.edad,
                sector = empleado.sector

            };

            context.Empleados.Add(nuevoEmpleado);
            context.SaveChanges();

        }

    }
}
