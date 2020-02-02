using KlientuValdymoSistema.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KlientuValdymoSistema.UI.Data
{
    public interface IKlientuDataService
    {
        Task<List<Klientas>> GautiVisus();
    }
}