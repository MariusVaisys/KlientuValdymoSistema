using KlientuValdymoSistema.Model;
using System.Collections.Generic;

namespace KlientuValdymoSistema.UI.Data
{
    public interface IKlientuDataService
    {
        IEnumerable<Klientas> GautiVisus();
    }
}