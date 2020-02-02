using KlientuValdymoSistema.Model;
using KlientuValdymoSistema.UI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientuValdymoSistema.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IKlientuDataService _klientuDataService;
        private Klientas _pasirinktasKlientas;


        public MainViewModel(IKlientuDataService klientuDataService)
        {
            Klientas = new ObservableCollection<Klientas>();
            _klientuDataService = klientuDataService;
        }

        public void Load()
        {
            var klientai = _klientuDataService.GautiVisus();
            Klientas.Clear();
            foreach (var klientas in klientai)
            {
                Klientas.Add(klientas);
            }
        }
        public ObservableCollection<Klientas> Klientas { get; set; }

        

        public Klientas PasirinktasKlientas
        {
            get { return _pasirinktasKlientas; }
            set {
                _pasirinktasKlientas = value;
                OnPropertyChanged();
            }
        }

    }
}
