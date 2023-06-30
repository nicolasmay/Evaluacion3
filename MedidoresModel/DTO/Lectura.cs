using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Lectura
    {


        private DateTime fecha;
        private String minuto;
        private String hora;
        private int valorConsumo;
        private Medidor medidorElegido;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Minuto { get => minuto; set => minuto = value; }
        
        public int ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
        public Medidor MedidorElegido { get => medidorElegido; set => medidorElegido = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
