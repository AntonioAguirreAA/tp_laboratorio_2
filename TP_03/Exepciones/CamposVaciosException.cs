using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class CamposVaciosException:Exception
    {
        public CamposVaciosException() : base("Se deben completar todos los campos", null)
        { }

        public CamposVaciosException(Exception inner) : base("Se deben completar todos los campos", inner)
        { }
    }
}
