using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PoderSecundarioNegocio
    {
        public List<string> listarPoderes(int id)
        {
            List<String> listaPoderes = new List<string>();
            listaPoderes.Add("Vista biónica");
            listaPoderes.Add("Velocidad");
            return listaPoderes;
        }
    }
}
