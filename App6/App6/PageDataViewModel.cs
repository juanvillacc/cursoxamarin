using App6.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6
{
    public class PageDataViewModel
    {
        public string Titulo { get; private set; }
        public string Descripcion { get; private set; }
        public Type Tipo { get; set; }

        public PageDataViewModel(string titulo, string descripcion, Type tipo)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Tipo = tipo;
        }
        static PageDataViewModel()
        {
            Paginas = new List<PageDataViewModel> {
                new PageDataViewModel("Binding page","Pagina con demo de binding",typeof(BindingCollectionsPage)),
                new PageDataViewModel("Constraint expression","Pagina con demo de ConstraintExpression",typeof(ConstrainExpressionPage)),
                new PageDataViewModel("MVVM page","Pagina con demo de MVVM", typeof(MVVMPage))
            };

        }
        public static List<PageDataViewModel> Paginas { get; set; }
      }
}
