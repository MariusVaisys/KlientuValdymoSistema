using KlientuValdymoSistema.DataAccess;
using KlientuValdymoSistema.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientuValdymoSistema.UI.Data
{
    class KlientuDataService : IKlientuDataService
    {
        private Func<KlientuValdymoSistemaDbContext> _contextCreator;

        public KlientuDataService(Func<KlientuValdymoSistemaDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<List<Klientas>> GautiVisus()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Klientai.AsNoTracking().ToListAsync();
                
            }
        }
    }
}
