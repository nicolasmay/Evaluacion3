using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Medidor
    {

        String numeroSerie;
        String tipoMedidor;

        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string TipoMedidor { get => tipoMedidor; set => tipoMedidor = value; }
    }
}
