using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    // Padrão Adapter para adaptar a interface do Email para a interface de envio
    interface IAdapterEnvioEmail
    {
        void Enviar();
    }
}
