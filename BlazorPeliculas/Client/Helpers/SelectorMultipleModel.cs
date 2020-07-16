using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
    public struct SelectorMultipleModel
    {
        public SelectorMultipleModel(string _llave, string _valor)
        {
            Llave = _llave;
            Valor = _valor;
        }

        public string Llave { get; set; }
        public string Valor { get; set; }
    }
}
