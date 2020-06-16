using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
    public class StringUtilities
    {
        /// <summary>
        /// Retorna texto en mayúscula
        /// </summary>
        /// <param name="value">String a convertir</param>
        /// <returns></returns>
        public static string CovertToUpper(string value) => value.ToUpper();
    }
}
