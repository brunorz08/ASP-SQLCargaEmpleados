using CargaDeEmpleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CargaDeEmpleados.Pages
{
    public class BorrarModel : PageModel
    {
        public ListadoEmpleados list;
        public BorrarModel(ListadoEmpleados lista) {
            list = lista;
        
        }    
        public void OnGet()
        {
          
            list.BorrarEmpleado(Convert.ToInt32(Request.Query["Id"]));
            Response.Redirect("Listar");
        }
    }
}
