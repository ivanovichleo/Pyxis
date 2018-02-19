using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public  class Respuesta
    {
        private string rta;
        private string codigo;
        public void setCodigo(String Codigo)
        {
            codigo = Codigo;
        }
        public String getCodigo()
        {
            return codigo;
        }
        public void setRTA(String RTA)
        {
            rta = RTA;
        }
        public String getRTA()
        {
            return rta;
        }

    }
}
