using CargaDeEmpleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CargaDeEmpleados.Pages
{
    public class IndexModel : PageModel

    {


        public ListadoEmpleados lista;
        public IndexModel(ListadoEmpleados list)
        {
            lista = list;
        }
        

        public void OnGet()
        {

        }

        public void OnPost()
        {
            lista.InsertarEmpleado(new Empleado()
                {
                nombre = Request.Form["nombre"],
                edad = Convert.ToInt32(Request.Form["edad"]),
                sector = Request.Form["sector"]


            });
        }
    }
}