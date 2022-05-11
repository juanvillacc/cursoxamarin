using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using App6.Pages;
namespace App6
{
    static class CapaDatos
    {
        public static List<Cliente> Clientes { get; set; } = new List<Cliente>()
        {
            new Cliente{
                Nombre = "Camilo",Apellido =    "Villa", EsActivo = true
                },
            new Cliente{
                Nombre = "Ana",Apellido =    "Correa", EsActivo = false
                },
            new Cliente{
                Nombre = "Juan",Apellido =    "Villa", EsActivo = true
                },
            new Cliente{
                Nombre = "Oscar",Apellido =    "Correa", EsActivo = false
                }
        };
        

    }
}
