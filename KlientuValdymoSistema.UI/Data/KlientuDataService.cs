using KlientuValdymoSistema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientuValdymoSistema.UI.Data
{
    class KlientuDataService : IKlientuDataService
    {
        public IEnumerable<Klientas> GautiVisus()
        {
            yield return new Klientas { Vardas = "Tomas", Pavarde = "Tomilinas" };
            yield return new Klientas { Vardas = "Andrius", Pavarde = "Kubilius" };
            yield return new Klientas { Vardas = "Ruta", Pavarde = "Tomiliene" };
        }
    }
}
