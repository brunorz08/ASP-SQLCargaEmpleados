using CargaDeEmpleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CargaDeEmpleados.Pages
{
    public class ListarModel : PageModel
    {
        public ListadoEmpleados listaa;
        public ListarModel(ListadoEmpleados lista)
        {
            listaa = lista;
        }
        public void OnGet()
        {
        }
    }
}
