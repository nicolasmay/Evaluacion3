using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        public List<Medidor> ObtenerMedidores()
        {
            return new List<Medidor>()
            {
                new Medidor()
                {
                    NumeroSerie = "M-1",
                    TipoMedidor = "Calibres de anillos"
                },
                new Medidor()
                {
                    NumeroSerie = "M-2",
                    TipoMedidor = "Calibres de pasadores"
                },
                new Medidor()
                {
                    NumeroSerie = "M-1",
                    TipoMedidor = "Calibres de anillos"
                },
                new Medidor()
                {
                    NumeroSerie = "M-1",
                    TipoMedidor = "Calibres de anillos"
                }

            };

        }
    }
}
