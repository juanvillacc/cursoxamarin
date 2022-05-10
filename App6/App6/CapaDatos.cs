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
                Nombre = "Camilo",Apellido =    "Villa"
                },
            new Cliente{
                Nombre = "Ana",Apellido =    "Correa"
                }
        };
        

    }
}
