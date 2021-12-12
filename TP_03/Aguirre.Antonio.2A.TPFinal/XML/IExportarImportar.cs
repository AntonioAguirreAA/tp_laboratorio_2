using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    interface IExportarImportar<T>
    {
        bool Exportar(T datos);
        bool Importar(out T datos);
    }
}
