using MedidoresModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();

        
    }
}
