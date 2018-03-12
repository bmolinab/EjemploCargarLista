using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploCargarLista.Models
{/// <summary>
/// El modelo de los datos que deseas recivir
/// </summary>
    public class AmortizacionModel
    {
        public int numCuota { get; set; }
        public double numSaldo { get; set; }
        public double numInteres { get; set; }
        public double numCapital { get; set; }
        public double numCuotaMensual { get; set; }
    }
}
